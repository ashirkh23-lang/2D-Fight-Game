using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace _2D_Fight_Game
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Connect Database to system
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = db_users.accdb;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open(); //Runs a query to check if username and password match existing details
            string login = "SELECT * FROM tbl_users WHERE username= '"+txtbox_username.Text+"' and password= '"+txtbox_password.Text+"'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true) //Event if the username and password entered match existing details
            {
                new frmHomeScreen().Show();
                this.Hide();
            }
            else //Event if the username and password entered do not match existing details 
            {
                MessageBox.Show("Invalid username or password, please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_username.Text = "";
                txtbox_password.Text = ""; //Resets the username and password text box 
            }


        }

        private void btn_MainMenu_Click(object sender, EventArgs e) //Clicking the button takes user back to Main Menu
        {
            new MainMenu().Show();
            this.Hide();
        }
    }
}
