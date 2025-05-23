﻿namespace GerenciamentoDeEntrega
{
    partial class Conteudo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteudo));
            navBar = new Panel();
            botaoMinimizar = new PictureBox();
            botaoFechar = new PictureBox();
            panelCentral = new Panel();
            navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)botaoMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botaoFechar).BeginInit();
            SuspendLayout();
            // 
            // navBar
            // 
            navBar.BackColor = Color.DarkRed;
            navBar.Controls.Add(botaoMinimizar);
            navBar.Controls.Add(botaoFechar);
            navBar.Dock = DockStyle.Top;
            navBar.Location = new Point(0, 0);
            navBar.Name = "navBar";
            navBar.Size = new Size(876, 50);
            navBar.TabIndex = 0;
            navBar.MouseDown += navBar_MouseDown;
            navBar.MouseMove += navBar_MouseMove;
            navBar.MouseUp += navBar_MouseUp;
            // 
            // botaoMinimizar
            // 
            botaoMinimizar.Cursor = Cursors.Hand;
            botaoMinimizar.Image = Properties.Resources.icons8_linha_horizontal_50__1_;
            botaoMinimizar.Location = new Point(772, 3);
            botaoMinimizar.Name = "botaoMinimizar";
            botaoMinimizar.Size = new Size(43, 44);
            botaoMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            botaoMinimizar.TabIndex = 1;
            botaoMinimizar.TabStop = false;
            botaoMinimizar.Click += botaoMinimizar_Click_1;
            // 
            // botaoFechar
            // 
            botaoFechar.Cursor = Cursors.Hand;
            botaoFechar.Image = Properties.Resources.icons8_excluir_50__1_;
            botaoFechar.Location = new Point(821, 3);
            botaoFechar.Name = "botaoFechar";
            botaoFechar.Size = new Size(43, 44);
            botaoFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            botaoFechar.TabIndex = 0;
            botaoFechar.TabStop = false;
            botaoFechar.Click += botaoFechar_Click;
            // 
            // panelCentral
            // 
            panelCentral.Location = new Point(0, 50);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(876, 569);
            panelCentral.TabIndex = 1;
            // 
            // Conteudo
            // 
            ClientSize = new Size(876, 619);
            Controls.Add(panelCentral);
            Controls.Add(navBar);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Conteudo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += telaLogin_Load;
            navBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)botaoMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)botaoFechar).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel navBar;
        private PictureBox botaoMinimizar;
        private PictureBox botaoFechar;
        private Panel panelCentral;
    }
}
