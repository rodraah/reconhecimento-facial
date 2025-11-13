using FaceRecognitionDotNet;

namespace RecFacial;

/// <summary>
/// Representa o resultado de um reconhecimento facial.
/// </summary>
public class RecognitionResult
{
    public string Name { get; set; } = "Desconhecido";
    public Rectangle Location { get; set; }
    public FaceEncoding Encode { get; set; }
}

/// <summary>
/// Core de Reconhecimento Facial. Encapsula a lógica de detecção e comparação.
/// </summary>
public class FacialRecognizer : IDisposable
{
    private readonly FaceRecognition _faceRecognition;
    private const double Tolerance = 0.6; // Nível de tolerância para comparação. Menor = mais estrito.

    /// <summary>
    /// Inicializa o reconhecedor facial, carregando os modelos do Dlib.
    /// </summary>
    /// <param name="modelsDirectory">O caminho para a pasta que contém os arquivos .dat do Dlib.</param>
    public FacialRecognizer(string modelsDirectory)
    {
        _faceRecognition = FaceRecognition.Create(modelsDirectory);
        Console.WriteLine("Core de Reconhecimento Facial inicializado.");
    }

    /// <summary>
    /// Gera a "assinatura" numérica (encoding) de um único rosto em uma imagem.
    /// </summary>
    /// <param name="image">Bitmap da imagem contendo um rosto.</param>
    /// <returns>O FaceEncoding do rosto ou null se nenhum ou mais de um rosto for encontrado.</returns>
    public FaceEncoding? GenerateEncoding(Bitmap image)
    {
        // Converte o Bitmap para um formato que a biblioteca entende.
        using var frImage = FaceRecognition.LoadImage(image);

        // Detecta a localização de rostos na imagem.
        var locations = _faceRecognition.FaceLocations(frImage).ToArray();

        // Para gerar um encoding de uma pessoa conhecida, esperamos exatamente um rosto na foto.
        if (locations.Length != 1)
        {
            Console.WriteLine($"AVISO: A imagem de treinamento deve conter exatamente um rosto. {locations.Length} rostos encontrados.");
            return null;
        }

        // Extrai a "assinatura" (encoding) do rosto encontrado.
        // Pegamos o primeiro (e único) resultado.
        var encoding = _faceRecognition.FaceEncodings(frImage, new[] { locations[0] }).FirstOrDefault();
        return encoding;
    }

    /// <summary>
    /// Detecta todos os rostos em um frame e tenta reconhecê-los comparando com um dicionário de rostos conhecidos.
    /// </summary>
    /// <param name="frame">O frame da câmera ou imagem de teste.</param>
    /// <param name="knownFaces">Um dicionário onde a chave é o nome da pessoa e o valor é o seu FaceEncoding.</param>
    /// <returns>Uma lista de resultados de reconhecimento, contendo nomes e localizações.</returns>
    public List<RecognitionResult> DetectAndRecognize(Bitmap frame, Dictionary<string, FaceEncoding> knownFaces)
    {
        var results = new List<RecognitionResult>();

        using var frImage = FaceRecognition.LoadImage(frame);

        var faceLocations = _faceRecognition.FaceLocations(frImage).ToArray();

        if (!faceLocations.Any())
        {
            return results;
        }

        // 2. Gera o encoding para cada rosto encontrado no frame
        var faceEncodings = _faceRecognition.FaceEncodings(frImage, faceLocations).ToArray();
        //Debug.WriteLine(String.Join("; ", faceEncodings[0].GetRawEncoding().Select(n => n.ToString("F10"))));

        var knownEncodings = knownFaces.Values.ToList();
        var knownNames = knownFaces.Keys.ToList();

        // 3. Itera sobre cada encoding encontrado no frame
        for (int i = 0; i < faceEncodings.Length; i++)
        {
            var currentEncoding = faceEncodings[i];
            var location = faceLocations[i];

            // 4. Compara o rosto atual com TODOS os rostos conhecidos
            var comparisons = FaceRecognition.CompareFaces(knownEncodings, currentEncoding, Tolerance).ToArray();

            string name = "Desconhecido";

            // 5. Verifica se houve alguma correspondência
            int matchIndex = Array.FindIndex(comparisons, c => c);
            if (matchIndex != -1)
            {
                name = knownNames[matchIndex];
            }

            results.Add(new RecognitionResult
            {
                Name = name,
                Location = new Rectangle(location.Left, location.Top, location.Right - location.Left, location.Bottom - location.Top),
            });

            currentEncoding.Dispose();
        }

        return results;
    }

    /// <summary>
    /// Libera os recursos utilizados pela biblioteca FaceRecognition.
    /// </summary>
    public void Dispose()
    {
        _faceRecognition?.Dispose();
    }
}