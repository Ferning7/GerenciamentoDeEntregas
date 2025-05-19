using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GerenciamentoDeEntrega
{
    public class Rota
    {

        private string cep;

        // atributos da rota

        private string status;
        private DateTime dataEmissao;

        //atributos ocorrencia da rota

        private string ocorrencia;
        private DateTime dataOcorrencia;


        // atributos relacao rota

        private int idRota;
        private int idOcorrencia;




        public string Cep
        {

            get { return cep; } 
            set { cep = value; }

        }


        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime DataEmissao
        {


            get { return dataEmissao; }
            set { dataEmissao = value; }


        }

        public string Ocorrencia
        {
            get { return ocorrencia; }
            set { ocorrencia = value; }
        }

        public DateTime DataOcorrencia 
        {

            get { return dataOcorrencia; }
            set { dataOcorrencia = value; }

        }

        public int IdRota
        {
            get { return idRota; }
            set { idRota = value; }
        }
        public int IdOcorrencia
        {
            get { return idOcorrencia; }
            set { idOcorrencia = value; }

        }

        public static List<Rota> BuscarRotaT(string cep)
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
                    INNER JOIN ocorrencia_rota o ON o.id_ocorrencia = rr.id_ocorrencia
                    WHERE o.cep = @cep";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@cep", cep);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar rotas: " + ex.Message);
            }

            return listaRotas;
        }

        public List<Rota> BuscarRota(string cep)
        {
            List<Rota> listaOcorrencias = new List<Rota>();

            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string sql = @"
                SELECT r.data_emissao, r.status_rota, o.ocorrencia, o.data_ocorrencia
                FROM rota r
                INNER JOIN relacao_rota rr ON rr.id_rota = r.id
                INNER JOIN ocorrencia_rota o ON o.id_ocorrencia = rr.id_ocorrencia
                WHERE r.cep_entrega = @cep";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@cep", cep);

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

                            listaOcorrencias.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar rota: " + ex.Message);
            }

            return listaOcorrencias;
        }


    }
}
