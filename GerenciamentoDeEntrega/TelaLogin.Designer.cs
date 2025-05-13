namespace GerenciamentoDeEntrega
{
    partial class telaLogin
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
            btnLogin = new Button();
            linkCadastrar = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            txtCredencialLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            lblLogin = new Label();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            PanelLogin = new Panel();
            pictureBox3 = new PictureBox();
            SenhaMostrando = new PictureBox();
            MostrarSenha = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SenhaMostrando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarSenha).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkRed;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(117, 468);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 56);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Cursor = Cursors.Hand;
            linkCadastrar.LinkColor = Color.DarkRed;
            linkCadastrar.Location = new Point(143, 527);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(100, 29);
            linkCadastrar.TabIndex = 1;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastrar";
            linkCadastrar.LinkClicked += lblCadastrar_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 192);
            label1.Name = "label1";
            label1.Size = new Size(143, 29);
            label1.TabIndex = 2;
            label1.Text = "Usuário/Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 289);
            label2.Name = "label2";
            label2.Size = new Size(72, 29);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // txtCredencialLogin
            // 
            txtCredencialLogin.Location = new Point(44, 224);
            txtCredencialLogin.Name = "txtCredencialLogin";
            txtCredencialLogin.Size = new Size(272, 35);
            txtCredencialLogin.TabIndex = 4;
            txtCredencialLogin.TextChanged += txtCredencialLogin_TextChanged;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(44, 321);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(272, 35);
            txtSenhaLogin.TabIndex = 5;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(120, 84);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(123, 45);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Login";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Arial Narrow", 10F);
            linkLabel2.LinkColor = Color.DarkRed;
            linkLabel2.Location = new Point(44, 359);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(130, 24);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Esqueci a senha";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 50);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_linha_horizontal_50__1_;
            pictureBox2.Location = new Point(765, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_excluir_50__1_;
            pictureBox1.Location = new Point(824, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PanelLogin
            // 
            PanelLogin.Controls.Add(pictureBox3);
            PanelLogin.Controls.Add(SenhaMostrando);
            PanelLogin.Controls.Add(MostrarSenha);
            PanelLogin.Controls.Add(lblLogin);
            PanelLogin.Controls.Add(linkLabel2);
            PanelLogin.Controls.Add(linkCadastrar);
            PanelLogin.Controls.Add(btnLogin);
            PanelLogin.Controls.Add(label1);
            PanelLogin.Controls.Add(txtCredencialLogin);
            PanelLogin.Controls.Add(txtSenhaLogin);
            PanelLogin.Controls.Add(label2);
            PanelLogin.Dock = DockStyle.Fill;
            PanelLogin.Location = new Point(0, 0);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(876, 619);
            PanelLogin.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CorrEzes;
            pictureBox3.Location = new Point(388, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(489, 572);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // SenhaMostrando
            // 
            SenhaMostrando.Cursor = Cursors.Hand;
            SenhaMostrando.Image = Properties.Resources.icons8_visível_50;
            SenhaMostrando.Location = new Point(324, 318);
            SenhaMostrando.Name = "SenhaMostrando";
            SenhaMostrando.Size = new Size(39, 40);
            SenhaMostrando.SizeMode = PictureBoxSizeMode.StretchImage;
            SenhaMostrando.TabIndex = 9;
            SenhaMostrando.TabStop = false;
            SenhaMostrando.Click += SenhaMostrando_Click;
            // 
            // MostrarSenha
            // 
            MostrarSenha.Cursor = Cursors.Hand;
            MostrarSenha.Image = Properties.Resources.icons8_cego_64;
            MostrarSenha.Location = new Point(324, 319);
            MostrarSenha.Name = "MostrarSenha";
            MostrarSenha.Size = new Size(39, 40);
            MostrarSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            MostrarSenha.TabIndex = 8;
            MostrarSenha.TabStop = false;
            MostrarSenha.Click += MostrarSenha_Click;
            // 
            // telaLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(876, 619);
            Controls.Add(panel1);
            Controls.Add(PanelLogin);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "telaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)SenhaMostrando).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarSenha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private LinkLabel linkCadastrar;
        private Label label1;
        private Label label2;
        private TextBox txtCredencialLogin;
        private TextBox txtSenhaLogin;
        private Label lblLogin;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel PanelLogin;
        private PictureBox MostrarSenha;
        private PictureBox SenhaMostrando;
        private PictureBox pictureBox3;
    }
}
