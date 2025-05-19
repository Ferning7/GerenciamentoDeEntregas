namespace GerenciamentoDeEntrega.UserControls
{
    partial class UC_HomeFunc
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
            dgvRotas = new DataGridView();
            btnAtualizar = new Button();
            btnListar = new Button();
            BtnExcluir = new Button();
            btnEditar = new Button();
            txtCep = new TextBox();
            lblcep = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRotas).BeginInit();
            SuspendLayout();
            // 
            // dgvRotas
            // 
            dgvRotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRotas.Location = new Point(0, 180);
            dgvRotas.Name = "dgvRotas";
            dgvRotas.Size = new Size(576, 196);
            dgvRotas.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(477, 12);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(96, 36);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(477, 138);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(96, 36);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(477, 96);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(96, 36);
            BtnExcluir.TabIndex = 3;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(477, 54);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 36);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(136, 25);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(171, 23);
            txtCep.TabIndex = 5;
            // 
            // lblcep
            // 
            lblcep.AutoSize = true;
            lblcep.Location = new Point(81, 28);
            lblcep.Name = "lblcep";
            lblcep.Size = new Size(28, 15);
            lblcep.TabIndex = 6;
            lblcep.Text = "CEP";
            // 
            // UC_HomeFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblcep);
            Controls.Add(txtCep);
            Controls.Add(btnEditar);
            Controls.Add(BtnExcluir);
            Controls.Add(btnListar);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvRotas);
            Name = "UC_HomeFunc";
            Size = new Size(576, 376);
            ((System.ComponentModel.ISupportInitialize)dgvRotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRotas;
        private Button btnAtualizar;
        private Button btnListar;
        private Button BtnExcluir;
        private Button btnEditar;
        private TextBox txtCep;
        private Label lblcep;
    }
}
