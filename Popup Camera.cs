using AForge.Video.DirectShow;

namespace RecFacial
{
    public partial class PopupFoto : Form
    {
        private FilterInfoCollection filterInfo;
        private VideoCaptureDevice videoCaptureDevice;
        private Usuario user;

        public PopupFoto()
        {
            InitializeComponent();

            // Seleção da câmera
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice();

            foreach (FilterInfo device in filterInfo)
            {
                comboCameras.Items.Add(device.Name);
            }

            comboCameras.SelectedIndex = comboCameras.Items.Count - 1;
        }

        public Usuario GetUsuario()
        {
            return user;
        }
        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap fotoAutenticacao = (Bitmap)picCamera.Image.Clone();
                user = Backend.Autenticar(fotoAutenticacao);
                MessageBox.Show($"Usuário reconhecido: \n{user.Nome}", "Reconhecimento Facial");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar: " + ex.Message);
            }
        }

        private void comboCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            picCamera.Image = null;
            videoCaptureDevice.SignalToStop();
            videoCaptureDevice = new VideoCaptureDevice(filterInfo[comboCameras.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            picCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void PopupFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCaptureDevice.SignalToStop();
        }
    }
}
