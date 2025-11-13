using System.Data;
using System.Drawing.Drawing2D;

namespace RecFacial
{
    public partial class TelaTabela : Form
    {
        private static List<Agrotoxico> agrotoxicos = Banco.GetAgrotoxicos();

        public TelaTabela(Usuario user)
        {
            InitializeComponent();

            var dados = PopularDataTable(user);

            labelUsuario.Text = $"Usuário: {user.Nome}";
            labelPrivilegio.Text = $"Privilégio: {user.Privilegio}";

            tabelaAgro.Columns.Clear();

            var FillSize = DataGridViewAutoSizeColumnMode.Fill;
            tabelaAgro.DataSource = dados;
            tabelaAgro.Columns["Produto"].AutoSizeMode = FillSize;
            tabelaAgro.Columns["Número de Registro"].Width = 175;
            tabelaAgro.Columns["Classificação Ambiental"].AutoSizeMode = FillSize;
            tabelaAgro.Columns["Fabricante"].Width = 150;
            tabelaAgro.Columns["Classe"].AutoSizeMode = FillSize;

            tabelaAgro.Columns[0].DefaultCellStyle.Padding = new Padding(10, 2, 2, 2);

        }

        private static DataTable PopularDataTable(Usuario user)
        {
            DataTable dados = new DataTable();
            dados.Clear();
            dados.Columns.Add("Produto", typeof(string));
            dados.Columns.Add("Número de Registro", typeof(string));
            dados.Columns.Add("Classificação Ambiental", typeof(string));
            dados.Columns.Add("Fabricante", typeof(string));
            dados.Columns.Add("Classe", typeof(string));

            // Ordem das classes
            var ordemClasses = new List<string> { "Classe I", "Classe II", "Classe III", "Classe IV" };

            foreach (var agrotoxico in agrotoxicos)
            {
                int idxClasse = ordemClasses.IndexOf(agrotoxico.Class_Ambiental);

                // Privilégio 0: nenhum acesso
                if (user.Privilegio == 0)
                    continue;

                // Mostra somente os agrotoxicos com classe ambiental menor que o privilégio do usuário
                if (idxClasse >= 0 && idxClasse < user.Privilegio)
                {
                    dados.Rows.Add(agrotoxico.Produto, agrotoxico.Numero_Registro, agrotoxico.Class_Ambiental, agrotoxico.Fabricante, agrotoxico.Classe);
                }
            }

            return dados;
        }

        // Gradiente
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Gradiente
            Color corInicial = Color.FromArgb(40, 117, 35);
            Color corFinal = Color.FromArgb(109, 148, 37);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, corInicial, corFinal, LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
