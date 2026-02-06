namespace _2D_Fight_Game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            new FrmSignIn().Show();
            this.Hide();
        }
    }
}
