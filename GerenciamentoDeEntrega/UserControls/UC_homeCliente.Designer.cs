namespace GerenciamentoDeEntrega.UserControls
{
    partial class UC_homeCliente
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
            label1 = new Label();
            txtCep = new TextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            btnBuscarRota = new Button();
            pnlRotas = new Panel();
            lblDataOcorrencia = new Label();
            lblOcorrencia = new Label();
            lblStatus = new Label();
            lblData = new Label();
            pnlRotas.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 81);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(214, 78);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(131, 23);
            txtCep.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 119);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(214, 116);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(131, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(178, 22);
            label3.Name = "label3";
            label3.Size = new Size(188, 40);
            label3.TabIndex = 4;
            label3.Text = "Buscar rota";
            // 
            // btnBuscarRota
            // 
            btnBuscarRota.Location = new Point(385, 78);
            btnBuscarRota.Name = "btnBuscarRota";
            btnBuscarRota.Size = new Size(88, 28);
            btnBuscarRota.TabIndex = 5;
            btnBuscarRota.Text = "Buscar";
            btnBuscarRota.UseVisualStyleBackColor = true;
            btnBuscarRota.Click += btnBuscarRota_Click;
            // 
            // pnlRotas
            // 
            pnlRotas.Controls.Add(lblDataOcorrencia);
            pnlRotas.Controls.Add(lblOcorrencia);
            pnlRotas.Controls.Add(lblStatus);
            pnlRotas.Controls.Add(lblData);
            pnlRotas.Location = new Point(4, 163);
            pnlRotas.Name = "pnlRotas";
            pnlRotas.Size = new Size(570, 214);
            pnlRotas.TabIndex = 6;
            // 
            // lblDataOcorrencia
            // 
            lblDataOcorrencia.AutoSize = true;
            lblDataOcorrencia.Location = new Point(42, 115);
            lblDataOcorrencia.Name = "lblDataOcorrencia";
            lblDataOcorrencia.Size = new Size(0, 15);
            lblDataOcorrencia.TabIndex = 3;
            // 
            // lblOcorrencia
            // 
            lblOcorrencia.AutoSize = true;
            lblOcorrencia.Location = new Point(42, 86);
            lblOcorrencia.Name = "lblOcorrencia";
            lblOcorrencia.Size = new Size(0, 15);
            lblOcorrencia.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(42, 59);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 1;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(42, 34);
            lblData.Name = "lblData";
            lblData.Size = new Size(0, 15);
            lblData.TabIndex = 0;
            // 
            // UC_homeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRotas);
            Controls.Add(btnBuscarRota);
            Controls.Add(label3);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(txtCep);
            Controls.Add(label1);
            Name = "UC_homeCliente";
            Size = new Size(576, 376);
            Load += UC_homeCliente_Load;
            pnlRotas.ResumeLayout(false);
            pnlRotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCep;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Button btnBuscarRota;
        private Panel pnlRotas;
        private Label lblDataOcorrencia;
        private Label lblOcorrencia;
        private Label lblStatus;
        private Label lblData;
    }
}
