using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thesis
{
    public partial class Registration : Form
    {

        string connectionString = "Server=localhost;Database=thesis borrowing;Uid=root;Pwd=;";

        public Registration()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string studentNumber = txt_studentnumber.Text;  
            string password = txt_password.Text;
            string studentName = txt_studentname.Text;      
            string course = txt_course.Text;     
            
            if (string.IsNullOrWhiteSpace(studentNumber) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(studentName) ||
                string.IsNullOrWhiteSpace(course))
            {
                lblerror.Text = "Please fill in all fields.";
                return;
            }

            if (SignupUser(studentNumber, password, studentName, course))
            {
                MessageBox.Show("Sign-up successful!");
            }
            else
            {
                lblerror.Text = "Sign-up failed. Please try again.";
            }
        }

        private bool SignupUser(string studentNumber, string password, string studentName, string course)
        {
            string query = "INSERT INTO registration (Student_number, Password, Student_name, Course) " +
                           "VALUES (@studentNumber, @password, @studentName, @course)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Use parameters to avoid SQL injection attacks
                        command.Parameters.AddWithValue("@studentNumber", studentNumber);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@studentName", studentName);
                        command.Parameters.AddWithValue("@course", course);

                        int result = command.ExecuteNonQuery();

                        // If one row was inserted, return true (sign-up successful)
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
