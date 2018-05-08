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

/*************************************************************************************************************
 * Form3 allows user to choose a catagory that the user want to add 
 * User can select the type of a recipe to add it will show the next new form
 * Form3 will be add new feutures later 
 * SQL query will be changed to parameterized queries later to avoid injection attack
 * author: Pablo Li (Jun JIE LI) 
 ************************************************************************************************************/

namespace Bakery_Book
{
    public partial class Form3 : Form{

        private string connectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private Form2 f2;
        public static string Form3_Pass_values_to_Form4 = "";

        public Form3(){
            InitializeComponent();
            Connection_Setup();
        }

        /*this method set up the basic connection to Microsoft SQL Server*/
        private void Connection_Setup(){
            connectionString = "Data Source=DESKTOP-S1F9JU1\\PABLOLJJDATABASE;Initial Catalog=RECEPIdatabase;Integrated Security=True";
            cmd = new SqlCommand();
            con = new SqlConnection(connectionString);
        }

        private void Form3_Load(object sender, EventArgs e){
            show_items();
        }

        /*this method shows all table names in database except the user table*/
        private void show_items(){
            string query = @"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES Where Not TABLE_NAME='UserID';";
            DataTable list = new DataTable();
            try{
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                adapter.Fill(list);
                comboBox1.DisplayMember = "TABLE_NAME";
                comboBox1.DataSource = list;
            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }
            finally{
                con.Close();
            }
        }

        /*this button opens the next form*/
        private void button1_Click(object sender, EventArgs e){
            Form3_Pass_values_to_Form4 = comboBox1.Text;
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        /*this button goes back to form2*/
        private void button2_Click(object sender, EventArgs e){
            this.Hide();
            f2 = new Form2();
            f2.Show();
        }
    }
}
