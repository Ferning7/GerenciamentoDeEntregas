using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GerenciamentoDeEntrega
{
    public class Gerenciamento
    {

        private int id;
        private string nome;
        private string email;
        private string senha;
        private string cep;
        private string permissao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Permissao
        {
            get { return permissao; }
            set { permissao = value; }
        }

        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);
                    string sqlInsert = "INSERT INTO usuarios (nome, email, senha, cep, permissao) VALUES (@nome, @email, @senha, @cep, @permissao)";

                    MySqlCommand comando = new MySqlCommand(sqlInsert, conexaoBanco);

                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);
                    comando.Parameters.AddWithValue("@cep", Cep);
                    comando.Parameters.AddWithValue("@permissao", "usuario");

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário :: {ex.Message}");
                return false;
            }
        }

        public bool verificarLogin()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);

                    string consultaUsuarios = "SELECT COUNT(*) FROM usuarios WHERE email = @email and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(consultaUsuarios, conexao);

                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar login no banco -> " + ex.Message);
                return false;
            }
        }

        public static bool ValidarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        public bool verificarEmailExistente()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string sqlconsultaEmail = "select COUNT(*) from usuarios where email = @email ";

                    MySqlCommand comando = new MySqlCommand(sqlconsultaEmail, conexaoBanco);
                    comando.Parameters.AddWithValue("@email", Email);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());
                    if (resultado > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar email {ex.Message}");
                return false;
            }
        }

        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }

                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public string BuscarNome()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);

                    string buscarNome = "SELECT nome FROM usuarios WHERE email = @email and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(buscarNome, conexao);

                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return resultado.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar o nome do usuário!" + ex.Message);
                return "";
            }
        }

        public bool BuscarCadastro()
        {
            using (MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                try
                {
                    string sqlConsulta = "SELECT COUNT(*) FROM usuarios WHERE nome = @nome OR email = @email";

                    MySqlCommand consulta = new MySqlCommand(sqlConsulta, conexao);
                    consulta.Parameters.AddWithValue("@nome", Nome);
                    consulta.Parameters.AddWithValue("@email", Email);

                    long quantidade = (long)consulta.ExecuteScalar();

                    if (quantidade > 0)
                    {
                        MessageBox.Show("Esse usuário já existe!");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro na verificação de cadastro: {ex.Message}");
                    return false;
                }
            }
        }

        public 


    }
}
