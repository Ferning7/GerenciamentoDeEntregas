namespace GerenciamentoDeEntrega.UserControls
{
    partial class UC_Login
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox3 = new PictureBox();
            OcultarSenha = new PictureBox();
            MostrarSenha = new PictureBox();
            linkRecSenha = new LinkLabel();
            linkCadastrar = new LinkLabel();
            btnLogin = new Button();
            label1 = new Label();
            txtEmailL = new TextBox();
            txtSenhaL = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OcultarSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarSenha).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CorrEzesLogin;
            pictureBox3.Location = new Point(328, -3);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(489, 572);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // OcultarSenha
            // 
            OcultarSenha.Cursor = Cursors.Hand;
            OcultarSenha.Image = Properties.Resources.icons8_visível_50;
            OcultarSenha.Location = new Point(228, 241);
            OcultarSenha.Margin = new Padding(2);
            OcultarSenha.Name = "OcultarSenha";
            OcultarSenha.Size = new Size(27, 24);
            OcultarSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            OcultarSenha.TabIndex = 20;
            OcultarSenha.TabStop = false;
            OcultarSenha.Click += OcultarSenha_Click;
            // 
            // MostrarSenha
            // 
            MostrarSenha.Cursor = Cursors.Hand;
            MostrarSenha.Image = Properties.Resources.icons8_cego_64;
            MostrarSenha.Location = new Point(228, 241);
            MostrarSenha.Margin = new Padding(2);
            MostrarSenha.Name = "MostrarSenha";
            MostrarSenha.Size = new Size(27, 24);
            MostrarSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            MostrarSenha.TabIndex = 19;
            MostrarSenha.TabStop = false;
            MostrarSenha.Click += MostrarSenha_Click;
            // 
            // linkRecSenha
            // 
            linkRecSenha.AutoSize = true;
            linkRecSenha.Cursor = Cursors.Hand;
            linkRecSenha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRecSenha.LinkColor = Color.DarkRed;
            linkRecSenha.Location = new Point(32, 270);
            linkRecSenha.Margin = new Padding(2, 0, 2, 0);
            linkRecSenha.Name = "linkRecSenha";
            linkRecSenha.Size = new Size(109, 20);
            linkRecSenha.TabIndex = 3;
            linkRecSenha.TabStop = true;
            linkRecSenha.Text = "Esqueci a senha";
            linkRecSenha.LinkClicked += linkRecSenha_LinkClicked;
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Cursor = Cursors.Hand;
            linkCadastrar.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkCadastrar.LinkColor = Color.DarkRed;
            linkCadastrar.Location = new Point(104, 367);
            linkCadastrar.Margin = new Padding(2, 0, 2, 0);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(63, 20);
            linkCadastrar.TabIndex = 5;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastrar";
            linkCadastrar.LinkClicked += linkCadastrar_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkRed;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(83, 331);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 134);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // txtEmailL
            // 
            txtEmailL.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailL.Location = new Point(32, 166);
            txtEmailL.Margin = new Padding(2);
            txtEmailL.Name = "txtEmailL";
            txtEmailL.Size = new Size(192, 26);
            txtEmailL.TabIndex = 1;
            // 
            // txtSenhaL
            // 
            txtSenhaL.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaL.Location = new Point(32, 242);
            txtSenhaL.Margin = new Padding(2);
            txtSenhaL.Name = "txtSenhaL";
            txtSenhaL.Size = new Size(192, 26);
            txtSenhaL.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 215);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 14;
            label2.Text = "Senha";
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox3);
            Controls.Add(OcultarSenha);
            Controls.Add(MostrarSenha);
            Controls.Add(linkRecSenha);
            Controls.Add(linkCadastrar);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtEmailL);
            Controls.Add(txtSenhaL);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "UC_Login";
            Size = new Size(626, 472);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)OcultarSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox OcultarSenha;
        private PictureBox MostrarSenha;
        private LinkLabel linkRecSenha;
        private LinkLabel linkCadastrar;
        private Button btnLogin;
        private Label label1;
        private TextBox txtEmailL;
        private TextBox txtSenhaL;
        private Label label2;
    }
}
