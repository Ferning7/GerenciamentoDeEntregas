using MySql.Data.MySqlClient;
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
    public partial class UC_homeCliente : UserControl
    {
      
        public UC_homeCliente()
        {
            InitializeComponent();
            

        }

        private void UC_homeCliente_Load(object sender, EventArgs e)
        {

         

        }

        private void btnBuscarRota_Click(object sender, EventArgs e)
        {
           

            // Instância do objeto que tem o método BuscarRota
            var rota = new Rota();

            List<Rota> rotas = rota.BuscarRota(txtCep.Text);

            foreach (var ocorrencia in rotas)
            {
                
                
                
                lblData.AutoSize = true;
                lblData.Text = $"Data: {ocorrencia.DataEmissao.ToShortDateString()} ";
               
                lblStatus.AutoSize = true;
                lblStatus.Text = $"Status: {ocorrencia.Status} ";
                
               
                lblOcorrencia.AutoSize = true;
                lblOcorrencia.Text = $"Ocorrência: {ocorrencia.Ocorrencia} ";

              
                lblDataOcorrencia.AutoSize = true;
                lblDataOcorrencia.Text = $"Data Ocorrência: {ocorrencia.DataOcorrencia.ToShortDateString()}";

                
            }

            if (rotas.Count == 0)
            {
                MessageBox.Show("Nenhuma rota encontrada para o CEP informado.");
            }
        }
    }
}

