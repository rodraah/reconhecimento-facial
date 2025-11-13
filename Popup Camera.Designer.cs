using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace RecFacial
{
    partial class PopupFoto
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
            btnAutenticar = new Button();
            picCamera = new PictureBox();
            comboCameras = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            SuspendLayout();
            // 
            // btnAutenticar
            // 
            btnAutenticar.BackColor = Color.FromArgb(242, 245, 222);
            btnAutenticar.Cursor = Cursors.Hand;
            btnAutenticar.FlatAppearance.BorderSize = 0;
            btnAutenticar.FlatStyle = FlatStyle.System;
            btnAutenticar.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutenticar.Location = new Point(80, 390);
            btnAutenticar.Name = "btnAutenticar";
            btnAutenticar.Size = new Size(151, 58);
            btnAutenticar.TabIndex = 1;
            btnAutenticar.Text = "Autenticar";
            btnAutenticar.UseVisualStyleBackColor = true;
            btnAutenticar.Click += btnAutenticar_Click;
            // 
            // picCamera
            // 
            picCamera.BackColor = Color.Transparent;
            picCamera.BackgroundImage = Properties.Resources.icon;
            picCamera.BackgroundImageLayout = ImageLayout.Zoom;
            picCamera.Location = new Point(10, 20);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(290, 310);
            picCamera.SizeMode = PictureBoxSizeMode.Zoom;
            picCamera.TabIndex = 2;
            picCamera.TabStop = false;
            // 
            // comboCameras
            // 
            comboCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCameras.FlatStyle = FlatStyle.System;
            comboCameras.FormattingEnabled = true;
            comboCameras.Location = new Point(30, 350);
            comboCameras.Name = "comboCameras";
            comboCameras.Size = new Size(240, 23);
            comboCameras.TabIndex = 3;
            comboCameras.SelectedIndexChanged += comboCameras_SelectedIndexChanged;
            // 
            // PopupFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(314, 461);
            Controls.Add(comboCameras);
            Controls.Add(picCamera);
            Controls.Add(btnAutenticar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(330, 500);
            MinimumSize = new Size(330, 500);
            Name = "PopupFoto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reconhecimento Facial";
            FormClosing += PopupFoto_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAutenticar;
        private PictureBox picCamera;
        private ComboBox comboCameras;
    }
}
