using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RecFacial
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Icone = new PictureBox();
            btnLogin = new Button();
            Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)Icone).BeginInit();
            SuspendLayout();
            // 
            // Icone
            // 
            Icone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Icone.BackColor = Color.Transparent;
            Icone.Image = Properties.Resources.icon;
            Icone.Location = new Point(331, 147);
            Icone.Margin = new Padding(3, 4, 3, 4);
            Icone.Name = "Icone";
            Icone.Size = new Size(217, 381);
            Icone.SizeMode = PictureBoxSizeMode.Zoom;
            Icone.TabIndex = 0;
            Icone.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(252, 255, 218);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(354, 573);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(173, 77);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Fazer Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.FromArgb(251, 255, 218);
            Titulo.Location = new Point(263, 93);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(428, 41);
            Titulo.TabIndex = 3;
            Titulo.Text = "Controle de Agrotóxicos";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(894, 737);
            Controls.Add(Titulo);
            Controls.Add(btnLogin);
            Controls.Add(Icone);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(912, 784);
            MinimumSize = new Size(912, 784);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Agrotóxicos: Login";
            ((System.ComponentModel.ISupportInitialize)Icone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Icone;
        private Button btnLogin;

        private Label Titulo;
    }
}
