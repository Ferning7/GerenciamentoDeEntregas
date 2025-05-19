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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {



        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {



        }

        private void dgvRotas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Verifica se a célula editada é a coluna de status
            if (dgvRotas.Columns[e.ColumnIndex].Name == "Status")
            {
                // Obtém o novo valor da célula
                string novoStatus = dgvRotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                // Atualiza o status na base de dados
                Rota rota = (Rota)dgvRotas.Rows[e.RowIndex].DataBoundItem;
                rota.Status = novoStatus;
                // Aqui você pode adicionar o código para atualizar o status no banco de dados

                try
                {
                    using (MySqlConnection conexao = new ConexaoBD().Conectar())
                    {
                        string sql = "UPDATE rota SET status_rota = @status WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@status", novoStatus);
                        cmd.Parameters.AddWithValue("@id", dgvRotas.CurrentRow.Cells[6].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar status: " + ex.Message);
                }
            } 

        }

        

    }
}

