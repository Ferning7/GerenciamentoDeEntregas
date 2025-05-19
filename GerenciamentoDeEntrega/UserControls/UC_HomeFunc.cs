using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GerenciamentoDeEntrega.UserControls
{
    public partial class UC_HomeFunc : UserControl
    {
        public UC_HomeFunc()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            List<Rota> listaRotas = new List<Rota>();

            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string sql = @"
                SELECT r.data_emissao, r.status_rota, o.ocorrencia, o.data_ocorrencia
                FROM rota r
                INNER JOIN relacao_rota rr ON rr.id_rota = r.id
                INNER JOIN ocorrencia_rota o ON o.id_ocorrencia = rr.id_ocorrencia";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rota item = new Rota
                            {
                                DataEmissao = reader.GetDateTime("data_emissao"),
                                Status = reader.GetString("status_rota"),
                                Ocorrencia = reader.GetString("ocorrencia"),
                                DataOcorrencia = reader.GetDateTime("data_ocorrencia")
                            };

                            listaRotas.Add(item);
                        }
                    }
                }

                // Exibir no DataGridView
                dgvRotas.DataSource = null;
                dgvRotas.DataSource = listaRotas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar rotas: " + ex.Message);
            }
        }

    


    }
}

