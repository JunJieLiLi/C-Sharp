using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program uses simle OOP aggregation relationship 
 * author: Pablo Li
 */
namespace Customer_Invoice { 
    class Customer{

        /*attributes*/
        private int id;                                         
        private string name;
        private int discount;
        private char gender;

        /*c'tor with 4 arguments*/
        public Customer(int i, string n, char g, int d) {              
            id = i;
            name = n;
            gender = g;
            discount = d;
        }

        /*accessors*/
        public int getID() {
            return id;
        }
        public string getName() {
            return name;
        }
        public int getDiscount() {
            return discount;
        }

        /*mutator*/
        public void setDiscount(int d) {
            discount = d;
        }

        public void toString() {
            Console.WriteLine("  Customer name: {0} Gender: {1} Customer id: {2} Customer discount: {3}\n", name,gender,id,discount);
        }

    }

    class Invoice {                                             // aggregation relationship   Invoice <>-----Customer

        /*instances*/
        private int ID;
        private double amount;
        Customer customer;

        /*default c'tor*/
        public Invoice() { }

        /*c'tor with 3 arguments*/
        public Invoice (int id, double a, Customer c){
            ID = id;
            amount = a;
            customer = c;
        }

        /*accessors*/
        public int getID() {
            return ID;
        }
    
        public Customer GetCustomer() {
            return customer;
        }
        public double getAmount() {
            return amount;
        }
        public string getCustomerName() {
            return customer.getName();
        }

        /*mutators*/
        public void setCustomer(Customer c) {
            customer = c;
        }

        public void setAmount(double a) {
            amount = a;
        }
        
        /* this method return the totoal amount after discount*/
        public double getAmountAfterDiscount() {
            return amount-(amount*((double)customer.getDiscount() / 100));
        }

    }

    class Acount {                                           // aggregation relationship      Acount <>------Customer.

        /*instances*/
        private int id;
        Customer customer;
        private double balance = 0;

        /*defualt c'tor*/
        public Acount() { }
        
        /*c'tor with 3 arguments*/
        public Acount(int idd, Customer c, double b) {
            id = idd;
            customer = c;
            balance = b;
        }

        /*accessors*/
        public int getID() {
            return id;
        }
        public Customer GetCustomer() {
            return customer;
        }

        public double getBalance() {
            return balance;
        }
        
        public void toString() {
            Console.Write("Account ID: {0} Balance: {1}\n",id,balance);
            customer.toString();
        }
        public string getCustmer_Name() {
            return customer.getName();
        }

        public void setBalance(double b) {
            balance = b;
        }

        /*this method returns the balance after deposit*/
        public double Todeposit(double a) {
            balance = balance + a;
            return balance;
        }

        /*this method returns the balance after withdraw*/
        public double Towithdraw(double a) {

            if (balance >= a) {
                balance = balance - a;
            } 
            else {
                balance=0;
            }
            return balance;
        }
    }

    /*
     * This is test class that test all the methods in Customer, Invoice and Acount classes
     */
    class Program {                                                    
        static void Main(string[] args) {
            Customer c1 = new Customer(101,"Tom",'m',10);
            c1.toString();
            c1.setDiscount(5);
            c1.toString();

            Invoice in1 = new Invoice(102,1000,c1);
            Console.WriteLine("Invoice Id: {0} Amount: {1} Customer Name: {2} Customer Discount: {3} Amount after Discount: {4}\n", in1.getID(),in1.getAmount(), c1.getName(),c1.getDiscount(),in1.getAmountAfterDiscount());
            Acount a1 = new Acount(101,c1,100);

            Console.WriteLine("Initial Information:\n");
            a1.toString();

            Console.WriteLine("After deposit:\n");
            a1.Todeposit(12);
            a1.toString();

            Console.WriteLine("After withdraw:\n");
            a1.Towithdraw(23);
            a1.toString();
        }
    }
}
