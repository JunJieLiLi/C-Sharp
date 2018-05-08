using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/**********************************************************************************
 * Form1 is the login page of the application. 
 * It checks the user id and password and saved them in Microsoft SQL database.
 * Form1 will be add new feutures later 
 * author: Pablo Li (Jun JIE LI) 
 **********************************************************************************/

namespace Bakery_Book{
    public partial class Form1 : Form{

        private string connectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rd;

        public Form1(){
            InitializeComponent();
            Connection_Setup();
        }

        /*this method set up the basic connection to Microsoft SQL Server*/
        private void Connection_Setup() {
            connectionString = "Data Source=DESKTOP-S1F9JU1\\PABLOLJJDATABASE;Initial Catalog=RECEPIdatabase;Integrated Security=True";
            cmd = new SqlCommand();
            con = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void button1_Login_Click(object sender, EventArgs e){
            String user_name = textBox1.Text;
            String user_pass = textBox2.Text;
            String query=@"Select * From UserID";
            try{
                con.Open();
                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();
                while (rd.Read()){
                    /*checks if input is matched */
                    if ((rd["NAME"].ToString() == user_name) && (rd["PASSWORD"].ToString() == user_pass)){
                        MessageBox.Show("Login Successfully");
                        this.Hide();
                        Form2 login = new Form2();
                        login.ShowDialog();
                    }
                    else{
                        MessageBox.Show("Login Faild Try Again");
                    }
                }
            }
            catch (SqlException ex) { 
                MessageBox.Show(ex.Message);
            }
            finally {
                rd.Close();
                con.Close();
            }
        }

        /*this link label will be updated later to have a form that reset user's name and password*/
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            MessageBox.Show("Your Name and your desktop password ");
        }
  
    }
}
