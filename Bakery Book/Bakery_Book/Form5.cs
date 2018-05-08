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

/*********************************************************************************************************************
 * Form5 is the update data user interface . 
 * user can edit each value of the recipe that shows in the field and save the new updated information in the database
 * user can go back to form2  and reset data
 * Form5 will be add new feutures later 
 * SQL query will be changed to parameterized queries later to avoid injection attack
 * author: Pablo Li (Jun JIE LI) 
 ********************************************************************************************************************/

namespace Bakery_Book{
    public partial class Form5 : Form{
        private string connectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rd;
        private Form2 f2;

        public Form5(){
            InitializeComponent();
            Connection_Setup();

        }

        /*this method set up the basic connection to Microsoft SQL Server*/
        private void Connection_Setup(){
            connectionString = "Data Source=DESKTOP-S1F9JU1\\PABLOLJJDATABASE;Initial Catalog=RECEPIdatabase;Integrated Security=True";
            cmd = new SqlCommand();
            con = new SqlConnection(connectionString);
        }

        /*this method get the table name 
         * @param  param1 string name
         */
        private string Table_name(string name){
            string Name = name.ToLower();
            if (Name.Contains("bread") ){
                Name = "Bread";
            }
            else if (Name.Contains("cake") ){
                Name = "Cake";
            }
            else if (Name.Contains("cream brulee") ){
                Name = "Creme_Brulee";
            }
            else if (Name.Contains("mochi")){
                Name = "Mochi";
            }
            else if (Name.Contains("muffin")){
                Name = "Muffin";
            }
            else if (Name.Contains("scone")){
                Name = "Scone";
            }
            return Name;
        }

        /*
         * this name shows all value of a recipe
         * @param param1 string table name from user
         * @param param2 string Name of recipe name
         */
        private void getInfor(string table_Name,string Name) { 

            string query = @"Select * From "+ table_Name+" Where [NAME]='"+ Name+"';";
            cmd = new SqlCommand(query, con);
            try{
                con.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read()){
                    textBox1.Text = rd["NAME"].ToString();
                    textBox2.Text = rd["TYPE"].ToString();
                    textBox5.Text = rd["INGREDIENT"].ToString();
                    textBox6.Text = rd["INSTRUCTION"].ToString();
                    textBox3.Text = rd["Time used"].ToString();
                    textBox4.Text = rd[0].ToString();
                }
            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }
            finally {
                rd.Close();
                con.Close();
            }
        }

        /*this button updates a recipe*/
        private void button1_Click(object sender, EventArgs e){
            string Name = textBox1.Text;
            string Type = textBox2.Text;
            string Ingredient = textBox5.Text;
            string Instruction = textBox6.Text;
            string Time_used = textBox3.Text;
            string table_name = Table_name(Name);
            string id = textBox4.Text;
            try{
                string query = "Update "+ table_name+" Set NAME=@name,TYPE=@type,INGREDIENT=@ingredient, INSTRUCTION=@instruction, [Time used]=@time Where [ID]= @id;";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("type", Type);
                cmd.Parameters.AddWithValue("ingredient", Ingredient);
                cmd.Parameters.AddWithValue("instruction", Instruction);
                cmd.Parameters.AddWithValue("time", Time_used);

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

        /*this button recet all values*/
        private void button3_Click(object sender, EventArgs e){
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        /*this button go back to form 2*/
        private void button2_Click(object sender, EventArgs e){
            f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e){
            /*ones form 5 is load, the information about a recipe will be shown*/
            label8_catagory.Text = Form2.Form2_Pass_values_to_Form4;
            string table_name = Table_name(Form2.Form2_Pass_values_to_Form4);
            string search_name = Form2.Form2_Pass_values_to_Form4;
            getInfor(table_name, search_name);



        }
    }
}
