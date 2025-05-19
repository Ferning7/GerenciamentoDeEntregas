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
            dgvRotas.Location = new Point(4, 193);
            dgvRotas.Margin = new Padding(4, 5, 4, 5);
            dgvRotas.Name = "dgvRotas";
            dgvRotas.RowHeadersWidth = 62;
            dgvRotas.Size = new Size(819, 434);
            dgvRotas.TabIndex = 0;
            dgvRotas.CellEndEdit += dgvRotas_CellEndEdit;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(86, 90);
            btnAtualizar.Margin = new Padding(4, 5, 4, 5);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(137, 60);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(574, 90);
            btnListar.Margin = new Padding(4, 5, 4, 5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(137, 60);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(415, 90);
            BtnExcluir.Margin = new Padding(4, 5, 4, 5);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(137, 60);
            BtnExcluir.TabIndex = 3;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(254, 90);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(137, 60);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(194, 42);
            txtCep.Margin = new Padding(4, 5, 4, 5);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(243, 31);
            txtCep.TabIndex = 5;
            // 
            // lblcep
            // 
            lblcep.AutoSize = true;
            lblcep.Location = new Point(116, 47);
            lblcep.Margin = new Padding(4, 0, 4, 0);
            lblcep.Name = "lblcep";
            lblcep.Size = new Size(42, 25);
            lblcep.TabIndex = 6;
            lblcep.Text = "CEP";
            // 
            // UC_HomeFunc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblcep);
            Controls.Add(txtCep);
            Controls.Add(btnEditar);
            Controls.Add(BtnExcluir);
            Controls.Add(btnListar);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvRotas);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_HomeFunc";
            Size = new Size(823, 627);
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
