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
    public partial class UC_Cadastro : UserControl
    {
        public UC_Cadastro()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Conteudo c = new Conteudo();
            UC_Login login = new UC_Login();

            this.Controls.Clear();
            this.Controls.Add(login);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmailC.Text.Equals("") && !txtNomeUser.Text.Equals("") && !txtSenhaC.Text.Equals("") && !txtCep.Text.Equals(""))
                {

                    

                    Gerenciamento gerenciamento = new Gerenciamento();
                    gerenciamento.Email = txtEmailC.Text;
                    gerenciamento.Nome = txtNomeUser.Text;
                    gerenciamento.Senha = txtSenhaC.Text;
                    gerenciamento.Cep = txtCep.Text;

                    if (gerenciamento.BuscarCadastro())
                    {

                        if (Gerenciamento.ValidarEmail(txtEmailC.Text))
                        {
                            if (ServerCep.ValidarCep(gerenciamento.Cep))
                            {
                                
                                if (gerenciamento.CadastrarUsuario())
                                {
                                    MessageBox.Show("Cadastro realizado!");
                                    Conteudo c = new Conteudo();
                                    UC_Login login = new UC_Login();

                                    this.Controls.Clear();
                                    this.Controls.Add(login);
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao realizar cadastro");
                                        
                                }

                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Email inválido");
                           
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar :: {ex.Message}");

            }

        }

        private void UC_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

            if(txtCep.Text.Length > 8)
            {

                MessageBox.Show("CEP inválido!");
                btnCadastro.Enabled = false;
            
            }
            else
            {
                btnCadastro.Enabled = true;
            }


        }
    }
}
