using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GerenciamentoDeEntrega
{
    class ServerCep
    {


        public static Endereco BuscarCep(string cep)
        {
            try
            {

                string url = $"https://viacep.com.br/ws/{cep}/json/";

                using (WebClient client = new WebClient())
                {

                    string json = client.DownloadString(url);

                    Endereco endereco = JsonConvert.DeserializeObject<Endereco>(json);
                    return endereco;

                }


            }
            catch (Exception ex)
            {

                return null;

            }
        }

        public static bool ValidarCep(string cep)
        {
            try
            {
                Endereco endereco = BuscarCep(cep); // Supondo que BuscarCep retorne um Endereco

                if (endereco != null && !string.IsNullOrWhiteSpace(endereco.Logradouro))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("CEP inválido!", "Validação de CEP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CEP inválido: {ex.Message}", "Erro - Validar CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
