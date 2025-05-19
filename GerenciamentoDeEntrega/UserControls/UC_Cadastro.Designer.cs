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
            txtCep = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.LinkColor = Color.DarkRed;
            linkLogin.Location = new Point(704, 520);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(56, 25);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastro.Location = new Point(504, 12);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(339, 45);
            lblCadastro.TabIndex = 14;
            lblCadastro.Text = "Crie seu cadastro";
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.DarkRed;
            btnCadastro.Cursor = Cursors.Hand;
            btnCadastro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(568, 464);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(190, 58);
            btnCadastro.TabIndex = 4;
            btnCadastro.Text = "Cadastre-se";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // lblEmailCadastro
            // 
            lblEmailCadastro.AutoSize = true;
            lblEmailCadastro.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCadastro.Location = new Point(532, 250);
            lblEmailCadastro.Name = "lblEmailCadastro";
            lblEmailCadastro.Size = new Size(65, 29);
            lblEmailCadastro.TabIndex = 10;
            lblEmailCadastro.Text = "Email";
            // 
            // txtEmailC
            // 
            txtEmailC.Location = new Point(532, 286);
            txtEmailC.Name = "txtEmailC";
            txtEmailC.Size = new Size(273, 31);
            txtEmailC.TabIndex = 2;
            // 
            // txtNomeUser
            // 
            txtNomeUser.Location = new Point(532, 120);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(273, 31);
            txtNomeUser.TabIndex = 1;
            // 
            // lblUsuarioCadastro
            // 
            lblUsuarioCadastro.AutoSize = true;
            lblUsuarioCadastro.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioCadastro.Location = new Point(532, 86);
            lblUsuarioCadastro.Name = "lblUsuarioCadastro";
            lblUsuarioCadastro.Size = new Size(172, 29);
            lblUsuarioCadastro.TabIndex = 17;
            lblUsuarioCadastro.Text = "Nome de usuário";
            // 
            // txtSenhaC
            // 
            txtSenhaC.Location = new Point(532, 381);
            txtSenhaC.Name = "txtSenhaC";
            txtSenhaC.Size = new Size(273, 31);
            txtSenhaC.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(527, 345);
            label1.Name = "label1";
            label1.Size = new Size(72, 29);
            label1.TabIndex = 18;
            label1.Text = "Senha";
            // 
            // lblNomeObr
            // 
            lblNomeObr.AutoSize = true;
            lblNomeObr.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeObr.ForeColor = Color.Red;
            lblNomeObr.Location = new Point(699, 91);
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
            label2.Location = new Point(592, 350);
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
            label3.Location = new Point(590, 253);
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
            label4.Location = new Point(568, 520);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 25;
            label4.Text = "Possui cadastro?";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CorrEzes;
            pictureBox3.Location = new Point(-19, 0);
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
            label5.Location = new Point(590, 168);
            label5.Name = "label5";
            label5.Size = new Size(21, 29);
            label5.TabIndex = 29;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(532, 165);
            label6.Name = "label6";
            label6.Size = new Size(50, 29);
            label6.TabIndex = 28;
            label6.Text = "Cep";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(532, 203);
            txtCep.Margin = new Padding(4, 5, 4, 5);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(273, 31);
            txtCep.TabIndex = 30;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // UC_Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtCep);
            Controls.Add(label5);
            Controls.Add(label6);
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
            Name = "UC_Cadastro";
            Size = new Size(871, 576);
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
        private MaskedTextBox txtCep;
    }
}
