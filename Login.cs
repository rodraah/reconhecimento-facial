using System.Drawing.Drawing2D;

namespace RecFacial
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (PopupFoto popup = new PopupFoto())
            {
                DialogResult result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var user = popup.GetUsuario();
                    using (var telaTabela = new TelaTabela(user))
                    {
                        this.Hide();
                        telaTabela.ShowDialog();
                        this.Show();
                    }
                }
            }
        }
    }
}
