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
            label1.Location = new Point(243, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 0;
            label1.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(306, 130);
            txtCep.Margin = new Padding(4, 5, 4, 5);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(185, 31);
            txtCep.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 37);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(284, 61);
            label3.TabIndex = 4;
            label3.Text = "Buscar rota";
            // 
            // btnBuscarRota
            // 
            btnBuscarRota.Location = new Point(550, 130);
            btnBuscarRota.Margin = new Padding(4, 5, 4, 5);
            btnBuscarRota.Name = "btnBuscarRota";
            btnBuscarRota.Size = new Size(126, 47);
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
            pnlRotas.Location = new Point(6, 272);
            pnlRotas.Margin = new Padding(4, 5, 4, 5);
            pnlRotas.Name = "pnlRotas";
            pnlRotas.Size = new Size(814, 357);
            pnlRotas.TabIndex = 6;
            // 
            // lblDataOcorrencia
            // 
            lblDataOcorrencia.AutoSize = true;
            lblDataOcorrencia.Location = new Point(60, 192);
            lblDataOcorrencia.Margin = new Padding(4, 0, 4, 0);
            lblDataOcorrencia.Name = "lblDataOcorrencia";
            lblDataOcorrencia.Size = new Size(0, 25);
            lblDataOcorrencia.TabIndex = 3;
            // 
            // lblOcorrencia
            // 
            lblOcorrencia.AutoSize = true;
            lblOcorrencia.Location = new Point(60, 143);
            lblOcorrencia.Margin = new Padding(4, 0, 4, 0);
            lblOcorrencia.Name = "lblOcorrencia";
            lblOcorrencia.Size = new Size(0, 25);
            lblOcorrencia.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(60, 98);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 1;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(60, 57);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(0, 25);
            lblData.TabIndex = 0;
            // 
            // UC_homeCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRotas);
            Controls.Add(btnBuscarRota);
            Controls.Add(label3);
            Controls.Add(txtCep);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_homeCliente";
            Size = new Size(823, 627);
            Load += UC_homeCliente_Load;
            pnlRotas.ResumeLayout(false);
            pnlRotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCep;
        private Label label3;
        private Button btnBuscarRota;
        private Panel pnlRotas;
        private Label lblDataOcorrencia;
        private Label lblOcorrencia;
        private Label lblStatus;
        private Label lblData;
    }
}
