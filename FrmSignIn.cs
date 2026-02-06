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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2D_Fight_Game
{
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();

        }

        //Connect Database to system
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = db_users.accdb;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();




        private void Signin_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "" &&  txtbox_password.Text == "") //Event if the fields are blank
            {
                MessageBox.Show("Username and password fields are blank", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Open();
            string register = "INSERT INTO tbl_users Values ('"+ txtbox_username.Text +"', '"+ txtbox_password.Text +"')";
            cmd = new OleDbCommand(register, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Set text field to empty
            txtbox_username.Text = "";
            txtbox_password.Text = "";

            MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_MainMenu_Click(object sender, EventArgs e) //Clicking the button takes user back to Main Menu
        {
            new MainMenu().Show();
            this.Hide(); 
        }
    }
}
