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
 * Form4 is the add new recipe user interface for user. 
 * User can add new recipe by providing value for each field and click save button
 * User can can reset all data and go to form 2 
 * Form4 will be add new feutures later 
 * SQL query will be changed to parameterized queries later to avoid injection attack
 * author: Pablo Li (Jun JIE LI) 
 ************************************************************************************************************/

namespace Bakery_Book
{
    public partial class Form4 : Form{

        private string connectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rd;
        private Form2 f2;

        public string TheValue { get; internal set; }

        public Form4(){
            Connection_Setup();
            InitializeComponent();
        }

        /*returns table name*/
        private string getTable_Name() {
            string name=Form3.Form3_Pass_values_to_Form4;  // pass the value from form 3 to form 4
            return name;
        }

        /*this method set up the basic connection to Microsoft SQL Server*/
        private void Connection_Setup(){
            connectionString = "Data Source=DESKTOP-S1F9JU1\\PABLOLJJDATABASE;Initial Catalog=RECEPIdatabase;Integrated Security=True";
            cmd = new SqlCommand();
            con = new SqlConnection(connectionString);
        }

        private void Form4_Load(object sender, EventArgs e){
            label2.Text = getTable_Name();
        }

        
        /*this button saves all value into sql database
         check existance and other method will be added later*/
        private void button2_Save_Click(object sender, EventArgs e){
            string table_name = getTable_Name();
            string name_input = textBox2_name.Text;
            string type_input = textBox3_type.Text;
            string ingredient_input = textBox5_ingredient.Text;
            string instruction_input = textBox6_instruction.Text;
            string time = textBox4_time.Text;

            string query = @"Insert Into " + table_name + "( [NAME] , [TYPE] , [INGREDIENT] , [INSTRUCTION] , [Time used])" +
                               " Values (" +"'"+ name_input+"',"+"'"+ type_input+"',"+"'"+ ingredient_input+"',"+ "'"+instruction_input+"',"+ "'"+time+"');";
            try{
                con.Open();
                cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                
                if (i != 0){
                    MessageBox.Show("Saved");
                }
                else{
                    MessageBox.Show("Error");
                }
            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }
            finally{
                con.Close();
            }
        }

        /*this button goes back to form2*/
        private void button1_Back_Click(object sender, EventArgs e){
            f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        /*this button reset all data*/
        private void button_Reset_Click(object sender, EventArgs e){
            textBox2_name.Clear();
            textBox3_type.Clear();
            textBox4_time.Clear();
            textBox5_ingredient.Clear();
            textBox6_instruction.Clear();
        }
        
        private void button1_Click(object sender, EventArgs e){
        }

        private void label3_Click(object sender, EventArgs e){

        }
    }
}
