namespace RecFacial
{
    partial class TelaTabela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tabelaAgro = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            NumRegistro = new DataGridViewTextBoxColumn();
            ClassAmbiental = new DataGridViewTextBoxColumn();
            Fabricante = new DataGridViewTextBoxColumn();
            Classe = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            labelUsuario = new Label();
            labelPrivilegio = new Label();
            ((System.ComponentModel.ISupportInitialize)tabelaAgro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabelaAgro
            // 
            tabelaAgro.AllowUserToAddRows = false;
            tabelaAgro.AllowUserToDeleteRows = false;
            tabelaAgro.AllowUserToResizeColumns = false;
            tabelaAgro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(1, 0, 0, 0);
            tabelaAgro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tabelaAgro.BackgroundColor = SystemColors.Window;
            tabelaAgro.BorderStyle = BorderStyle.None;
            tabelaAgro.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tabelaAgro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Menu;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2, 15, 2, 10);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tabelaAgro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tabelaAgro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaAgro.Columns.AddRange(new DataGridViewColumn[] { Produto, NumRegistro, ClassAmbiental, Fabricante, Classe });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(170, 230, 161);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tabelaAgro.DefaultCellStyle = dataGridViewCellStyle3;
            tabelaAgro.Dock = DockStyle.Bottom;
            tabelaAgro.EnableHeadersVisualStyles = false;
            tabelaAgro.GridColor = SystemColors.Window;
            tabelaAgro.Location = new Point(0, 161);
            tabelaAgro.Margin = new Padding(11, 13, 11, 13);
            tabelaAgro.MaximumSize = new Size(897, 640);
            tabelaAgro.MinimumSize = new Size(897, 640);
            tabelaAgro.Name = "tabelaAgro";
            tabelaAgro.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tabelaAgro.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tabelaAgro.RowHeadersVisible = false;
            tabelaAgro.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new Padding(1, 0, 0, 0);
            tabelaAgro.RowsDefaultCellStyle = dataGridViewCellStyle5;
            tabelaAgro.RowTemplate.DividerHeight = 1;
            tabelaAgro.RowTemplate.Height = 40;
            tabelaAgro.ScrollBars = ScrollBars.Vertical;
            tabelaAgro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaAgro.ShowEditingIcon = false;
            tabelaAgro.ShowRowErrors = false;
            tabelaAgro.Size = new Size(897, 640);
            tabelaAgro.TabIndex = 0;
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Produto.FillWeight = 90.90909F;
            Produto.HeaderText = "Produto";
            Produto.MinimumWidth = 6;
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            Produto.Resizable = DataGridViewTriState.False;
            // 
            // NumRegistro
            // 
            NumRegistro.HeaderText = "Número de Registro";
            NumRegistro.MinimumWidth = 175;
            NumRegistro.Name = "NumRegistro";
            NumRegistro.ReadOnly = true;
            NumRegistro.Width = 175;
            // 
            // ClassAmbiental
            // 
            ClassAmbiental.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClassAmbiental.FillWeight = 90.90909F;
            ClassAmbiental.HeaderText = "Classificação Ambiental";
            ClassAmbiental.MinimumWidth = 6;
            ClassAmbiental.Name = "ClassAmbiental";
            ClassAmbiental.ReadOnly = true;
            // 
            // Fabricante
            // 
            Fabricante.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Fabricante.HeaderText = "Fabricante";
            Fabricante.MinimumWidth = 150;
            Fabricante.Name = "Fabricante";
            Fabricante.ReadOnly = true;
            Fabricante.Width = 150;
            // 
            // Classe
            // 
            Classe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Classe.FillWeight = 90.90909F;
            Classe.HeaderText = "Classe";
            Classe.MinimumWidth = 6;
            Classe.Name = "Classe";
            Classe.ReadOnly = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(253, 254, 254);
            label1.Location = new Point(149, 0);
            label1.MaximumSize = new Size(250, 149);
            label1.MinimumSize = new Size(250, 149);
            label1.Name = "label1";
            label1.Size = new Size(250, 149);
            label1.TabIndex = 1;
            label1.Text = "Agrotóxicos";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 145);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.FromArgb(253, 254, 254);
            labelUsuario.Location = new Point(702, 50);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Padding = new Padding(0, 0, 20, 0);
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(106, 24);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuário: ";
            labelUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPrivilegio
            // 
            labelPrivilegio.AutoSize = true;
            labelPrivilegio.BackColor = Color.Transparent;
            labelPrivilegio.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrivilegio.ForeColor = Color.FromArgb(253, 254, 254);
            labelPrivilegio.Location = new Point(700, 90);
            labelPrivilegio.Name = "labelPrivilegio";
            labelPrivilegio.Padding = new Padding(0, 0, 20, 0);
            labelPrivilegio.Size = new Size(121, 24);
            labelPrivilegio.TabIndex = 4;
            labelPrivilegio.Text = "Privilégio: ";
            labelPrivilegio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TelaTabela
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(894, 801);
            Controls.Add(labelPrivilegio);
            Controls.Add(labelUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabelaAgro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(912, 848);
            MinimumSize = new Size(912, 848);
            Name = "TelaTabela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agrotóxicos";
            ((System.ComponentModel.ISupportInitialize)tabelaAgro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabelaAgro;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn NumRegistro;
        private DataGridViewTextBoxColumn ClassAmbiental;
        private DataGridViewTextBoxColumn Fabricante;
        private DataGridViewTextBoxColumn Classe;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelUsuario;
        private Label labelPrivilegio;
    }
}