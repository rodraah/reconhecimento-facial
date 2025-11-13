using SQLite;

namespace RecFacial
{
    public class Banco
    {
        private static string DbPath = "./banco.db";
        private static SQLiteAsyncConnection db;
        private static List<Usuario> usuarios = [];
        private static List<Agrotoxico> agrotoxicos = [];

        public static async void IniciarBanco()
        {
            if (!File.Exists(DbPath))
            {
                throw new FileNotFoundException("Arquivo de banco não encontrado.", DbPath);
            }

            db = new SQLiteAsyncConnection(DbPath);

            PopularBanco();
        }

        private static async void PopularBanco()
        {
            usuarios = await db.Table<Usuario>().ToListAsync();
            agrotoxicos = await db.Table<Agrotoxico>().ToListAsync();
        }



        public static List<Usuario> GetUsuarios()
        {
            return usuarios;
        }

        public static List<Agrotoxico> GetAgrotoxicos()
        {
            return agrotoxicos;
        }


        public static Usuario ProcurarUsuarioPorNome(string nome)
        {
            foreach (var i in usuarios)
            {
                if (i.Nome == nome)
                {
                    return i;
                }
            }

            throw new Exception($"Não foi encontrado um usuário com o nome {nome}");
        }
    }

    [Table("Usuarios")]
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Privilegio { get; set; }
        public byte[] Encode { get; set; }
    }

    [Table("Agrotoxicos")]
    public class Agrotoxico
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Produto { get; set; }
        public string Numero_Registro { get; set; }
        public string Class_Ambiental { get; set; }
        public string Fabricante { get; set; }
        public string Classe { get; set; }
    }
}
