/*********************************************************************************************************************************************************************
* This program calculates salary of different department using Polymorphism ,inheritance Multilevel inheritance, Hybrid inheritance , Virtual and Overriding concept
* author: Pablo Li (JunJie Li)
**********************************************************************************************************************************************************************/


using System;
using System.IO;
namespace employee_inheritance {
     
    class Employee {                                                     // base class
        protected string name;
        protected int year;

        public Employee(string n, int y) {                               // c'tor
            name = n;
            year = y;
        }
        public string getName() {                                        // accessor
            return name;
        }
        public int getYear() {                                           // accessor
            return year;
        }
        public virtual void tostring() {                                 // virtual method
            Console.WriteLine("name is: {0}  year: {1}", name, year);
        }

        public virtual double Salary() {                                 // virtual method  
            return 0;
        }
    }

    class Faculty : Employee {                                           // Faculty-> Employee
        protected int unit;
        protected double salaryPerUnit;


        public Faculty(string Employee_name, int Employee_name_year, int Faculty_unit, double Faculty_salaryPerUnit) : base(Employee_name, Employee_name_year) {    // (string n, int y) is for Employee, (int u, double s) is for Faculty
            unit = Faculty_unit;                                         // c'tor
            salaryPerUnit = Faculty_salaryPerUnit;
        }

        public int getUnit() {                                          // accessor
            return unit;
        }  
        public void setUnit(int u) {                                     // mutator
            unit = u;
        }
        public double getSalaryPerUnit() {                              // accessor  
            return salaryPerUnit;
        }
        public void setSalaryPerUnit(double s) {                         // mutator
            salaryPerUnit = s;
        }

    }
    class Staff : Employee {                                             // Staff->Employee
        protected int BaseSalary;

        public Staff(string Employee_name, int Employee_name_year, int Staff_baseSalary) : base(Employee_name, Employee_name_year) {   // the name of arguments have to be same
            BaseSalary = Staff_baseSalary;                              // c'tor
        }   

        public int getBaseSalary() {                                     //accessor
            return BaseSalary;
        }
    }
    class LabInstructor : Staff {                                         // LabInstructor->Staff
        protected int myBonus;

        public LabInstructor(string Employee_name, int Employee_year, int Staff_baseSalary, int LabInstructor_myBonus) : base(Employee_name, Employee_year, Staff_baseSalary) {
            myBonus = LabInstructor_myBonus;                               // c'tor
        }
        public override double Salary() {                                  // overrided method from base class to calculate Salary
            return BaseSalary + myBonus;
        }
        public override void tostring() {                                  // overrided method from base class to print information
            Console.WriteLine("Lab Instructor name: {0} Years: {1} Base Salary: {2} Bonus: {3} Salary: {4}",name,year,BaseSalary,myBonus,Salary());
        }
    }
    class InstructionalAsst : Staff {                                     // InstructionalAsst->Staff
        public InstructionalAsst(string Employee_name, int Employee_year, int Staff_baseSalary ) : base(Employee_name, Employee_year, Staff_baseSalary) {}     // c'tor

        public override double Salary() {                                 // overrided method from base class to calculate Salary
            return BaseSalary;
        }
        public override void tostring() {                                 // overrided method from base class to print information
            Console.WriteLine("Instructional Assestent name: {0} Years: {1} Salary {2}" , name,year,Salary());
        }

    } 
    class DeptHead : Faculty {                                             // DeptHead->Faculty
        private double bonus;

        public DeptHead(string Employee_name, int Employee_year,int Faculty_unit, double Faculty_salaryPerUnit, double DeptHead_bonus) : base(Employee_name, Employee_year, Faculty_unit, Faculty_salaryPerUnit) {
            bonus = DeptHead_bonus;                  // Employee <- Faculty <- DeptHead
        }
          
        public double getBonus() {                                        //accessor     
            return bonus; 
        }

        public override double Salary() {                                 // overrided method from base class to calculate Salary
            return unit * salaryPerUnit + bonus;
        }
        public override void tostring() {                                 // overrided method from base class to print information
            Console.WriteLine("Department head name: {0}  year: {1} unit: {2} salaryPerUnit: {3} Bonus: {4} Salary: {5} ", name, year, unit, salaryPerUnit,bonus,Salary());
            Console.WriteLine("this is the overridded method ");
        }
    }
    class Professor: Faculty {                                            //Professor-> Faculty
        public Professor(string Employee_name, int Employee_year, int Faculty_unit, double Faculty_salaryPerUnit): base(Employee_name, Employee_year, Faculty_unit, Faculty_salaryPerUnit) {}    // c'tor

        public override double Salary() {                                  // overrided method from base class to calculate Salary
            return unit*salaryPerUnit;
        }

        public override void tostring() {                                  // overrided method from base class to print information
            Console.WriteLine("Professor name: {0}  Year: {1} unit: {2} Salary Per Unit: {3} Salary: {4}",name,year,unit,salaryPerUnit,Salary());
        }
    }

    class Program{
        static void Main(string[] args){
            Faculty f1 = new Faculty("Tom",2017, 12, 43);    // Employee("Tom",2017)   Faculty(12,45000)
            Console.WriteLine();
            DeptHead h1 = new DeptHead("Tom", 2018, 01, 32, 100);
            h1.tostring();
            Console.WriteLine();
            Professor p1 = new Professor("Pablo",2018,02,200);
            p1.tostring();
            Console.WriteLine();
            LabInstructor l1 = new LabInstructor("Steve",2017,40000,200);
            l1.tostring();
            Console.WriteLine();
            InstructionalAsst in1 = new InstructionalAsst("Cindy",2017,30000);
            in1.tostring();
            // test

        }
    }
}
