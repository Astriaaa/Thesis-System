using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Thesis
{
    public partial class Login : Form
    {
        string connectionString = "Server=localhost;Database=thesis borrowing;Uid=root;Pwd=;";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;


            if (ValidateUser(username, password))
            {
                // show forms hereeee\
                this.Hide();
                Admin adminform = new Admin();
                adminform.ShowDialog();
                this.Show();
            }
            else
            {
                // label "error invalid username or passs"

                lblerror.Text = "Invalid username or password.";
            }

        }

        private bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM login WHERE username = @username AND password = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);


                        int result = Convert.ToInt32(command.ExecuteScalar());


                        return result == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration register_user = new Registration();
            register_user.ShowDialog();
            this.Show();

        }
    }
}
      


