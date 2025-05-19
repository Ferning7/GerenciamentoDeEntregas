using GerenciamentoDeEntrega.UserControls;

namespace GerenciamentoDeEntrega
{
    public partial class Conteudo : Form
    {
        bool mouseDown;
        Point lastLocation;

        public Conteudo()
        {
            InitializeComponent();

        }


        private void adicionarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void telaLogin_Load(object sender, EventArgs e)
        {
            UC_Login telaLogin = new UC_Login();
            adicionarUserControl(telaLogin);
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void navBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y
                );

            }
        }

        private void navBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void navBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void botaoMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

