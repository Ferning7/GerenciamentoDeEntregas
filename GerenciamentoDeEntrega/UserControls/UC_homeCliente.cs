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
        private Gerenciamento usuario = new Gerenciamento();
        public UC_homeCliente(string nome)
        {
            InitializeComponent();
            usuario.Nome = nome;

        }

        private void UC_homeCliente_Load(object sender, EventArgs e)
        {

         

        }

        private void btnBuscarRota_Click(object sender, EventArgs e)
        {



        }
    }
}

