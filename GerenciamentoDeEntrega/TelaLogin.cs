using GerenciamentoDeEntrega.UserControls;

namespace GerenciamentoDeEntrega
{
    public partial class telaLogin : Form
    {
        bool mouseDown;
        Point lastLocation;
        
        public telaLogin()
        {
            InitializeComponent();
        }

        private void adicionarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelLogin.Controls.Clear();
            PanelLogin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void txtCredencialLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Cadastro ucCadastro = new UC_Cadastro();
            adicionarUserControl(ucCadastro);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y
                );

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MostrarSenha_Click(object sender, EventArgs e)
        {
            SenhaMostrando.Visible = true;
        }

        private void SenhaMostrando_Click(object sender, EventArgs e)
        {
            SenhaMostrando.Visible = false;
        }
    }
}

