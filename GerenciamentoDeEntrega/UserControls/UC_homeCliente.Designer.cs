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
            textBox1 = new TextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            btnBuscarRota = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 121);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "CEP";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 159);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(220, 156);
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
            btnBuscarRota.Location = new Point(235, 202);
            btnBuscarRota.Name = "btnBuscarRota";
            btnBuscarRota.Size = new Size(88, 28);
            btnBuscarRota.TabIndex = 5;
            btnBuscarRota.Text = "Buscar";
            btnBuscarRota.UseVisualStyleBackColor = true;
            btnBuscarRota.Click += btnBuscarRota_Click;
            // 
            // UC_homeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBuscarRota);
            Controls.Add(label3);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UC_homeCliente";
            Size = new Size(576, 376);
            Load += UC_homeCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Button btnBuscarRota;
    }
}
