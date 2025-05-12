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
            btnLogin = new Button();
            lblEmailCadastro = new Label();
            txtEmailCadastro = new TextBox();
            txtSenhaLogin = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            lblUsuarioCadastro = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.LinkColor = Color.DarkRed;
            linkLogin.Location = new Point(268, 543);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(56, 25);
            linkLogin.TabIndex = 9;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastro.Location = new Point(206, 72);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(184, 45);
            lblCadastro.TabIndex = 14;
            lblCadastro.Text = "Cadastro";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkRed;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(227, 494);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 46);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Cadastrar";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblEmailCadastro
            // 
            lblEmailCadastro.AutoSize = true;
            lblEmailCadastro.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCadastro.Location = new Point(165, 144);
            lblEmailCadastro.Name = "lblEmailCadastro";
            lblEmailCadastro.Size = new Size(65, 29);
            lblEmailCadastro.TabIndex = 10;
            lblEmailCadastro.Text = "Email";
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Location = new Point(165, 176);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.Size = new Size(272, 31);
            txtEmailCadastro.TabIndex = 12;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(165, 436);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(272, 31);
            txtSenhaLogin.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(165, 404);
            label2.Name = "label2";
            label2.Size = new Size(172, 29);
            label2.TabIndex = 11;
            label2.Text = "Confirmar Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 31);
            textBox1.TabIndex = 16;
            // 
            // lblUsuarioCadastro
            // 
            lblUsuarioCadastro.AutoSize = true;
            lblUsuarioCadastro.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioCadastro.Location = new Point(165, 236);
            lblUsuarioCadastro.Name = "lblUsuarioCadastro";
            lblUsuarioCadastro.Size = new Size(174, 29);
            lblUsuarioCadastro.TabIndex = 17;
            lblUsuarioCadastro.Text = "Nome de Usuário";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 361);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 31);
            textBox2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 329);
            label1.Name = "label1";
            label1.Size = new Size(121, 29);
            label1.TabIndex = 18;
            label1.Text = "Criar senha";
            // 
            // UC_Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(lblUsuarioCadastro);
            Controls.Add(textBox1);
            Controls.Add(linkLogin);
            Controls.Add(lblCadastro);
            Controls.Add(btnLogin);
            Controls.Add(lblEmailCadastro);
            Controls.Add(txtEmailCadastro);
            Controls.Add(txtSenhaLogin);
            Controls.Add(label2);
            Name = "UC_Cadastro";
            Size = new Size(600, 619);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private LinkLabel linkLogin;
        private Label lblCadastro;
        private Button btnLogin;
        private Label lblEmailCadastro;
        private TextBox txtEmailCadastro;
        private TextBox txtSenhaLogin;
        private Label label2;
        private TextBox textBox1;
        private Label lblUsuarioCadastro;
        private TextBox textBox2;
        private Label label1;
    }
}
