using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeEntrega.UserControls
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
            txtSenhaL.UseSystemPasswordChar = true;
            OcultarSenha.Visible = false;
        }



        private void txtCredencialLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmailL.Text.Equals("") && !txtSenhaL.Text.Equals(""))
                {
                    Gerenciamento gerenciamento = new Gerenciamento();
                    gerenciamento.Email = txtEmailL.Text;
                    gerenciamento.Senha = txtSenhaL.Text;

                    if (Gerenciamento.ValidarEmail(txtEmailL.Text))
                    {
                        if (gerenciamento.verificarLogin())
                        {
                            HomeTeste home = new HomeTeste();
                            Conteudo c = new Conteudo();


                            this.Controls.Clear();
                            this.Controls.Add(home);
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha inválidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("formato de Email inválido");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível fazer login: {ex.Message}");

            }

        }


        private void OcultarSenha_Click(object sender, EventArgs e)
        {
            txtSenhaL.UseSystemPasswordChar = true;
            MostrarSenha.Visible = true;
            OcultarSenha.Visible = false;
        }

        private void MostrarSenha_Click(object sender, EventArgs e)
        {
            txtSenhaL.UseSystemPasswordChar = false;
            MostrarSenha.Visible = false;
            OcultarSenha.Visible = true;
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Conteudo c = new Conteudo();
            UC_Cadastro cadastro = new UC_Cadastro();

            this.Controls.Clear();
            this.Controls.Add(cadastro);

        }

        private void linkRecSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
