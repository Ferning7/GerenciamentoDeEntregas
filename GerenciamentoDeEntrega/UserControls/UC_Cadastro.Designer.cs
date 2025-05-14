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
            textBox1 = new TextBox();
            lblUsuarioCadastro = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            lblNomeObr = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.LinkColor = Color.DarkRed;
            linkLogin.Location = new Point(709, 548);
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
            lblCadastro.Location = new Point(512, 52);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(339, 45);
            lblCadastro.TabIndex = 14;
            lblCadastro.Text = "Crie seu cadastro";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkRed;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(573, 491);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 58);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Cadastre-se";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblEmailCadastro
            // 
            lblEmailCadastro.AutoSize = true;
            lblEmailCadastro.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCadastro.Location = new Point(533, 239);
            lblEmailCadastro.Name = "lblEmailCadastro";
            lblEmailCadastro.Size = new Size(65, 29);
            lblEmailCadastro.TabIndex = 10;
            lblEmailCadastro.Text = "Email";
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Location = new Point(533, 271);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.Size = new Size(272, 31);
            txtEmailCadastro.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(533, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 31);
            textBox1.TabIndex = 16;
            // 
            // lblUsuarioCadastro
            // 
            lblUsuarioCadastro.AutoSize = true;
            lblUsuarioCadastro.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioCadastro.Location = new Point(533, 154);
            lblUsuarioCadastro.Name = "lblUsuarioCadastro";
            lblUsuarioCadastro.Size = new Size(172, 29);
            lblUsuarioCadastro.TabIndex = 17;
            lblUsuarioCadastro.Text = "Nome de usuário";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(533, 376);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 31);
            textBox2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(533, 344);
            label1.Name = "label1";
            label1.Size = new Size(121, 29);
            label1.TabIndex = 18;
            label1.Text = "Criar senha";
            // 
            // lblNomeObr
            // 
            lblNomeObr.AutoSize = true;
            lblNomeObr.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeObr.ForeColor = Color.Red;
            lblNomeObr.Location = new Point(700, 160);
            lblNomeObr.Name = "lblNomeObr";
            lblNomeObr.Size = new Size(21, 29);
            lblNomeObr.TabIndex = 22;
            lblNomeObr.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(646, 350);
            label2.Name = "label2";
            label2.Size = new Size(21, 29);
            label2.TabIndex = 23;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(592, 243);
            label3.Name = "label3";
            label3.Size = new Size(21, 29);
            label3.TabIndex = 24;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(573, 548);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 25;
            label4.Text = "Possui cadastro?";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CorrEzes;
            pictureBox3.Location = new Point(0, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(489, 572);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // UC_Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox3);
            Controls.Add(linkLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNomeObr);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(lblUsuarioCadastro);
            Controls.Add(textBox1);
            Controls.Add(lblCadastro);
            Controls.Add(btnLogin);
            Controls.Add(lblEmailCadastro);
            Controls.Add(txtEmailCadastro);
            Name = "UC_Cadastro";
            Size = new Size(876, 617);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private TextBox textBox1;
        private Label lblUsuarioCadastro;
        private TextBox textBox2;
        private Label label1;
        private Label lblNomeObr;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
    }
}
