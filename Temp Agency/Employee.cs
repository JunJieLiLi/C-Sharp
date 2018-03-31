/****************************************************************************************************************************************
* The Employee class contains all the information about employee object which contains name, number of dependents, number of hours worked
* social security, federal tax, and agency fee
* it also contains the methods to calculate gross pay, net pay and agency fee and federal tax pay
* author: Pablo Li (JunJie Li)
******************************************************************************************************************************************/

namespace TempAgency {

    internal class Employee {
        /*const values*/
    private const double Hourly_rate = 150.00;
        private const double Social_Security_Rate = 0.0785;
        private const double Dependent_Allowance_Rate = 0.0575;
        private const double Agency_Charge_Rate = 0.13;
        private const double Federal_Tax_Rate = 0.25;

        /*attributes*/
        private string employeeName;
        private int no_Dependents;
        private double no_Hours;
        private double social_Security;
        private double federal_Tax;
        private double agency_Fee;
        private double gross;
        private double net;

        /*default c'tor*/
        public Employee() { }

        /*c'tor for 2 arguments*/
        public Employee(string name, double hour) {
            employeeName = name;
            no_Hours = hour;
        }

        /*c'tor with 3 arguments*/
        public Employee(string m, double h, int d) {
            employeeName = m;
            no_Hours = h;
            no_Dependents = d;
        }

        /*use const value "rate" to calculate the the gross pay*/
        public double Total_Gross() {
            gross = no_Hours * Hourly_rate;
            return gross;
        }

        /*return the total agency fee*/
        public double Total_Agency_Fee() {
            agency_Fee = gross * Agency_Charge_Rate;
            return agency_Fee;
        }

        /*use const value "dependent_allowance_rate" to calcualte the total federal tax*/
        public double Total_Federal_Tax() {

            federal_Tax = (gross - (gross * Dependent_Allowance_Rate * no_Dependents)) * Federal_Tax_Rate;
            return federal_Tax;
        }

        /*use const value "social_security_rate" to calculate the total security taxes*/
        public double Total_Social_Security() {
            social_Security = gross * Social_Security_Rate;
            return social_Security;
        }

        /*return the net pay*/
        public double Total_Net_Pay() {
            net = gross - social_Security - federal_Tax - agency_Fee;
            return net;
        }

        /*accessor and mutator for employee name */
        public string Employee_Name {
            set {
                employeeName = value;
            }
            get {
                return employeeName;
            }
        }

        /*accessor and mutator for number of dependents */
        public int Number_Department {
            set {
                no_Dependents = value;
            }
            get {
                return no_Dependents;
            }
        }

        /*accessor and mutator for number of Hourse worked */
        public double No_Hours {
            set {
                no_Hours = value;
            }
            get {
                return no_Hours;
            }
        }

        /*accessor and mutator for number of Social Security  */
        public double Social_Security {
            set {
                social_Security = value;
            }
            get {
                return social_Security;
            }
        }

        /*accessor and mutator for number of Federal Tax   */
        public double Federal_Tax {
            set {
                federal_Tax = value;
            }
            get {
                return federal_Tax;
            }
        }

        /*accessor and mutator for number of agency_Fee  */
        public double Agency_Fee {
            set {
                agency_Fee = value;
            }
            get {
                return agency_Fee;
            }
        }

        /*accessor and mutator for number of Gross  */
        public double Gross {
            set {
                gross = value;
            }
            get {
                return gross;
            }
        }

        /*accessor and mutator for number of Net  */
        public double Net {
            set {
                net = value;
            }
            get {
                return net;
            }
        }

    }
}