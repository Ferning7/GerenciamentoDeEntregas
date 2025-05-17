namespace GerenciamentoDeEntrega.UserControls
{
    partial class UC_Cadastro
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
            linkLogin = new LinkLabel();
            lblCadastro = new Label();
            btnCadastro = new Button();
            lblEmailCadastro = new Label();
            txtEmailC = new TextBox();
            txtNomeUser = new TextBox();
            lblUsuarioCadastro = new Label();
            txtSenhaC = new TextBox();
            label1 = new Label();
            lblNomeObr = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            txtCep = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.LinkColor = Color.DarkRed;
            linkLogin.Location = new Point(511, 416);
            linkLogin.Margin = new Padding(2, 0, 2, 0);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(37, 15);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastro.Location = new Point(362, 68);
            lblCadastro.Margin = new Padding(2, 0, 2, 0);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(229, 30);
            lblCadastro.TabIndex = 14;
            lblCadastro.Text = "Crie seu cadastro";
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.DarkRed;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(416, 382);
            btnCadastro.Margin = new Padding(2);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(133, 35);
            btnCadastro.TabIndex = 4;
            btnCadastro.Text = "Cadastre-se";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // lblEmailCadastro
            // 
            lblEmailCadastro.AutoSize = true;
            lblEmailCadastro.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCadastro.Location = new Point(375, 241);
            lblEmailCadastro.Margin = new Padding(2, 0, 2, 0);
            lblEmailCadastro.Name = "lblEmailCadastro";
            lblEmailCadastro.Size = new Size(45, 20);
            lblEmailCadastro.TabIndex = 10;
            lblEmailCadastro.Text = "Email";
            // 
            // txtEmailC
            // 
            txtEmailC.Location = new Point(375, 263);
            txtEmailC.Margin = new Padding(2);
            txtEmailC.Name = "txtEmailC";
            txtEmailC.Size = new Size(192, 23);
            txtEmailC.TabIndex = 2;
            // 
            // txtNomeUser
            // 
            txtNomeUser.Location = new Point(375, 162);
            txtNomeUser.Margin = new Padding(2);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(192, 23);
            txtNomeUser.TabIndex = 1;
            // 
            // lblUsuarioCadastro
            // 
            lblUsuarioCadastro.AutoSize = true;
            lblUsuarioCadastro.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioCadastro.Location = new Point(375, 143);
            lblUsuarioCadastro.Margin = new Padding(2, 0, 2, 0);
            lblUsuarioCadastro.Name = "lblUsuarioCadastro";
            lblUsuarioCadastro.Size = new Size(115, 20);
            lblUsuarioCadastro.TabIndex = 17;
            lblUsuarioCadastro.Text = "Nome de usuário";
            // 
            // txtSenhaC
            // 
            txtSenhaC.Location = new Point(375, 320);
            txtSenhaC.Margin = new Padding(2);
            txtSenhaC.Name = "txtSenhaC";
            txtSenhaC.Size = new Size(192, 23);
            txtSenhaC.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 298);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 18;
            label1.Text = "Senha";
            // 
            // lblNomeObr
            // 
            lblNomeObr.AutoSize = true;
            lblNomeObr.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeObr.ForeColor = Color.Red;
            lblNomeObr.Location = new Point(492, 146);
            lblNomeObr.Margin = new Padding(2, 0, 2, 0);
            lblNomeObr.Name = "lblNomeObr";
            lblNomeObr.Size = new Size(14, 20);
            lblNomeObr.TabIndex = 22;
            lblNomeObr.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(417, 301);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(14, 20);
            label2.TabIndex = 23;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(416, 243);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(14, 20);
            label3.TabIndex = 24;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(416, 416);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 25;
            label4.Text = "Possui cadastro?";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CorrEzes;
            pictureBox3.Location = new Point(-155, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(489, 572);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(416, 192);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(14, 20);
            label5.TabIndex = 29;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(375, 190);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 28;
            label6.Text = "Cep";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(375, 212);
            txtCep.Margin = new Padding(2);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(192, 23);
            txtCep.TabIndex = 27;
            // 
            // UC_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtCep);
            Controls.Add(pictureBox3);
            Controls.Add(linkLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNomeObr);
            Controls.Add(txtSenhaC);
            Controls.Add(label1);
            Controls.Add(lblUsuarioCadastro);
            Controls.Add(txtNomeUser);
            Controls.Add(lblCadastro);
            Controls.Add(btnCadastro);
            Controls.Add(lblEmailCadastro);
            Controls.Add(txtEmailC);
            Margin = new Padding(2);
            Name = "UC_Cadastro";
            Size = new Size(610, 469);
            Load += UC_Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private LinkLabel linkLogin;
        private Label lblCadastro;
        private Button btnCadastro;
        private Label lblEmailCadastro;
        private TextBox txtEmailC;
        private TextBox txtNomeUser;
        private Label lblUsuarioCadastro;
        private TextBox txtSenhaC;
        private Label label1;
        private Label lblNomeObr;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private TextBox txtCep;
    }
}
