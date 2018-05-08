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
 * Form2 is the main page of the application. 
 * User can search the name or the catagory of bakery recipes and look details of each one
 * User can Update recipes, delete recipes and add new recipes. Each of them will open in a new window form
 * Form2 will be add new feutures later 
 * SQL query will be changed to parameterized queries later to avoid injection attack
 * author: Pablo Li (Jun JIE LI) 
 ************************************************************************************************************/
namespace Bakery_Book
{
    public partial class Form2 : Form{
        private string connectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rd;
        private SqlDataAdapter adapter;
        private Form3 f3;
        private Form5 f5;
  
        public static string Form2_Pass_values_to_Form4 = "";
        public Form2(){
            InitializeComponent();
            Connection_Setup();
            f3 = new Form3();       
        }

        /*this method set up the basic connection to Microsoft SQL Server*/
        private void Connection_Setup(){
            connectionString = "Data Source=DESKTOP-S1F9JU1\\PABLOLJJDATABASE;Initial Catalog=RECEPIdatabase;Integrated Security=True";
            cmd = new SqlCommand();
            con = new SqlConnection(connectionString);
        }

        /*this method returns the table name that corresponds to the user's input.*/
        private string getTableName() {

            string tablename = "";
            
            if (textBox1.Text.ToLower().Contains("bread") || textBox2.Text.ToLower().Contains("bread")) {
                tablename = "Bread";
            }
            else if (textBox1.Text.ToLower().Contains("cake") || textBox2.Text.ToLower().Contains("cake")){
                tablename = "Cake";
            }
            else if (textBox1.Text.ToLower().Contains("cream brulee") || textBox2.Text.ToLower().Contains("cream brulee")){
                tablename = "Creme_Brulee";
            }
            else if (textBox1.Text.ToLower().Contains("mochi") || textBox2.Text.ToLower().Contains("mochi")){
                tablename = "Mochi";
            }
            else if (textBox1.Text.ToLower().Contains("muffin") || textBox2.Text.ToLower().Contains("muffin")){
                tablename = "Muffin";
            }
            else if (textBox1.Text.ToLower().Contains("scone") || textBox2.Text.ToLower().Contains("scone")){
                tablename = "Scone";
            }
            return tablename;
        }

        /*this method search the name that user is entered in the seach by name field*/
        private void Search_by_name() {
            string table_name = getTableName();
            string resuslt_name = "";
            string resuslt_type = "";
            string resuslt_ingredient = "";
            string resuslt_instruciton = "";
            string result_time = "";
            string query = @"Select * From ["+ table_name + "];";
            cmd = new SqlCommand(query, con);
            rd = cmd.ExecuteReader();

            while (rd.Read()){        // look through the whole table and get all required values
                if (rd["NAME"].ToString() == textBox1.Text) {
                    resuslt_name = rd["NAME"].ToString();
                    resuslt_type = rd["TYPE"].ToString();
                    resuslt_ingredient = rd["INGREDIENT"].ToString();
                    resuslt_instruciton = rd["INSTRUCTION"].ToString();
                    result_time = rd["Time used"].ToString();
                }
            }
            rd.Close();
            textBox3.Text = resuslt_name;
            textBox4.Text = resuslt_type;
            textBox5.Text = result_time;
            textBox6.Text = resuslt_ingredient;
            textBox7.Text = resuslt_instruciton;
        }

        /*this method search the type of the recipe that user is entered in the seach by catagory field 
         * and display them  */
        private void Search_by_catagory(){
            DataTable recipeTable = new DataTable();
            string table_name = getTableName();

            string query = @"Select * From ["+ table_name+"]";
            adapter = new SqlDataAdapter(query, con);
            adapter.Fill(recipeTable);
            listBox1.DisplayMember = "NAME";
            listBox1.DataSource = recipeTable;
            label7_FoundNumbers.Text = listBox1.Items.Count.ToString();
        }

        /*this method search all items in the listbox  and display them*/
        private void listBox_Search(){
            string table_name = getTableName();
            string name = listBox1.GetItemText(listBox1.SelectedItem);
            string query = @"Select * From ["+ table_name+"]"+"Where [NAME]='"+ name+"';";
            cmd = new SqlCommand(query, con);
            rd = cmd.ExecuteReader();
            while (rd.Read()) {    // look through the whole table and get all required values
                textBox6.Text = (string)rd["INGREDIENT"].ToString();
                textBox7.Text = (string)rd["INSTRUCTION"].ToString();
                textBox3.Text = (string)rd["NAME"].ToString();
                textBox4.Text = (string)rd["TYPE"].ToString();
                textBox5.Text = (string)rd["Time used"].ToString();
            }
            rd.Close();
        }

        /*this button search the name of the recipe  */
        private void button1_Search_Click(object sender, EventArgs e){
            try {
                con.Open();
                Search_by_name();
            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }
            finally{
                con.Close();
            }   
        }

        /*this method clear all data in all fields*/
        private void Reset() {
            listBox1.DataSource = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            label7_FoundNumbers.Text = "";
        }

        /*recet all data*/
        private void button_Reset_Click(object sender, EventArgs e){
            button2_Update.Enabled = false;
            button1_Delete.Enabled = false;
            button4_Look_Details.Enabled = false;
            label6.Hide();
            listBox1.Hide();
            label7_FoundNumbers.Hide();
            Reset();
        }

        /*shows all data of a recipe*/
        private void button4_Look_Details_Click(object sender, EventArgs e){
            try{
                con.Open();
                listBox_Search();
            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }
            finally{
                con.Close();

            }
        }

        /*this button leads to a new form that allow users to add new recipe*/
        private void button3_Add_new_Click(object sender, EventArgs e){
            this.Hide();
            f3.ShowDialog();
        }

        /*this button leads to a new form that allow users to update a existent recipe*/
        private void button2_Update_Click(object sender, EventArgs e){
            Form2_Pass_values_to_Form4 = listBox1.GetItemText(listBox1.SelectedItem); 
            this.Hide();
            f5 = new Form5();
            f5.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e){
            //listBox1.Show();
            listBox1.Hide();
            button2_Update.Enabled =false;
            button1_Delete.Enabled = false;
            label6.Hide();
            label7_FoundNumbers.Hide();
            button4_Look_Details.Enabled = false ;
        }

        /*it delete a recipe*/
        private void button1_Delete_Click(object sender, EventArgs e){

            string tablename = getTableName();
            string select_name = listBox1.GetItemText(listBox1.SelectedItem);
            string query = @"Delete From [" + tablename + "] Where NAME='"+ select_name + "';";

            cmd = new SqlCommand(query, con);

            try { 
                con.Open();
                rd = cmd.ExecuteReader();
            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }
            finally {
                Reset();
                con.Close();
                rd.Close();
                MessageBox.Show(" Data is now deleted");
            }
        }
        
        /*if the item is the listbox is less than 0 , then button is enable to click*/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){
            if (listBox1.Items.Count>0) {
                button1_Delete.Enabled = true;
            }
            else{
                button1_Delete.Enabled = false;
            }
        }

        /*this button search the type of a recipe and show all the values*/
        private void button1_Click(object sender, EventArgs e){
            try{
                label6.Show();
                button4_Look_Details.Enabled = true;
                label7_FoundNumbers.Show();
                listBox1.Show();
                con.Open();
                Search_by_catagory();
            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }
            finally{
                con.Close();
            }
        }

        /*this is an image box that will display the image that correspond to the user's recipe which will be implemented later*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
