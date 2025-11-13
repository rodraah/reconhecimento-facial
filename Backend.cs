using FaceRecognitionDotNet;

namespace RecFacial
{
    internal class Backend
    {
        private static string modelsPath = "./models";
        private static FacialRecognizer recognizer = new FacialRecognizer(modelsPath);

        public static Usuario Autenticar(Bitmap foto)
        {
            var knownFaces = CarregarFacesConhecidas();
            List<RecognitionResult> resultado = recognizer.DetectAndRecognize(foto, knownFaces);

            foreach (RecognitionResult rosto in resultado)
            {
                return Banco.ProcurarUsuarioPorNome(rosto.Name);
            }

            throw new Exception("Usuário não reconhecido.");
        }

        private static Dictionary<String, FaceEncoding> CarregarFacesConhecidas()
        {
            List<Usuario> usuarios = Banco.GetUsuarios();
            Dictionary<String, FaceEncoding> knownFaces = [];

            foreach (Usuario usuario in usuarios)
            {
                double[] enc = ByteParaEncode(usuario.Encode);
                FaceEncoding encode = FaceRecognition.LoadFaceEncoding(enc);
                knownFaces.Add(usuario.Nome, encode);
            }

            return knownFaces;
        }

        public static byte[] EncodeParaByte(double[] encoding)
        {
            if (encoding == null) throw new ArgumentNullException(nameof(encoding));
            var floats = Array.ConvertAll(encoding, d => (float)d);
            var bytes = new byte[floats.Length * 4];
            Buffer.BlockCopy(floats, 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static double[] ByteParaEncode(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));
            int count = bytes.Length / 4;
            var floats = new float[count];
            Buffer.BlockCopy(bytes, 0, floats, 0, bytes.Length);
            var doubles = new double[count];
            for (int i = 0; i < count; i++) doubles[i] = floats[i];
            return doubles;
        }
    }
}
