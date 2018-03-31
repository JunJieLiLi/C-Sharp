using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempAgency {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            SetVisibility(false);                                                                  // hid Gross pay, federal ded, soc se ded, angency fee and net pay 
        }

        private void buttonCalculate_Click(object sender, EventArgs e) {
           
            string name = textBoxName.Text;                                                        //get the name data from Name textbutton                                   
            int hour = Convert.ToInt32(textBoxHourWork.Text);                                      //get the hour data from textbox hour button
            double nu_dep = Convert.ToInt32(textBoxNoDepart.Text);                                 //get the number data of department from the depart textbutton and convert from string to int  

            if (nu_dep != 0) {                                                                     // check if number of department is 0

                Employee employee = new Employee(name, nu_dep, hour);                              // create an Employee object and assign name, hour,nu_dep attributes 
                textBoxGrossPay.Text = Convert.ToString(employee.Total_Gross());                   // call the Total_Gross() method to get the value of total gross and convert it from double to string and store in the Gross Pay button to display
                textBoxFederalDed.Text = Convert.ToString(employee.Total_Federal_Tax());           // same as Total_Gross, but call Total_Federal_Tax() instead
                textBoxSocSec.Text = Convert.ToString(employee.Total_Social_Security());           // same as Total_Social_Security(), but call Total_Social_Security() instead
                textBoxAgencyFee.Text = Convert.ToString(employee.Total_Agency_Fee());             // same as Total_Agency_Fee(), but call Total_Agency_Fee() instead
                textBoxNetPay.Text = Convert.ToString(employee.Total_Net_Pay());                   // same as Total_Net_Pay(), but call Total_Net_Pay() instead


            } else if(nu_dep == 0) {
                
                Employee employee = new Employee(name,hour);
                textBoxGrossPay.Text = Convert.ToString(employee.Total_Gross());                 
                textBoxFederalDed.Text = Convert.ToString(employee.Total_Federal_Tax());           
                textBoxSocSec.Text = Convert.ToString(employee.Total_Social_Security());           
                textBoxAgencyFee.Text = Convert.ToString(employee.Total_Agency_Fee());             
                textBoxNetPay.Text = Convert.ToString(employee.Total_Net_Pay());                   

            }
            textBoxName.Enabled = false;                                                          // set the Enabled function to false
            textBoxHourWork.Visible = false;                                                      // hide the hour button once the calculate button is clicked
            textBoxNoDepart.Visible = false;                                                      // hide the number of department button once the calculate button is clicked
            No_Hours_Worked_label.Visible = false;                                                // hide the hour label once the calculate button is clicked
            No_of_Departments_label.Visible = false;                                              // hide the nuber of department label once the calculate button is clicked
            SetVisibility(true);                                                                  // set the visibility to true
              

        }
       
        private void buttonReset_Click(object sender, EventArgs e) { 

            textBoxName.Text = "";                                                                // way one to reset the name text button
            textBoxHourWork.Clear();                                                              // wat two to call Cleear() method to reset the hour button
            textBoxNoDepart.Text = "";
            textBoxGrossPay.Text = "";
            textBoxFederalDed.Clear();
            textBoxSocSec.Text = "";
            textBoxAgencyFee.Clear();
            textBoxNetPay.Text = "";

            textBoxName.Enabled = true;
            textBoxHourWork.Visible = true;
            textBoxNoDepart.Visible = true;
            No_Hours_Worked_label.Visible = true;
            No_of_Departments_label.Visible = true;
            SetVisibility(false);




        }
        private void SetVisibility(bool vi) {
            Gross_Pay_label.Visible = vi;
            Federal_Ded_label.Visible = vi;
            Soc_Sec_Ded_lebel.Visible = vi;
            Agency_Fee_label.Visible = vi;
            Net_Pay_label.Visible = vi;

            textBoxGrossPay.Visible = vi;
            textBoxFederalDed.Visible = vi;
            textBoxSocSec.Visible = vi;
            textBoxAgencyFee.Visible = vi;
            textBoxNetPay.Visible = vi;
        }

     
    }
}
