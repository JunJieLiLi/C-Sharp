using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class uses simple OOP aggregation relationship. Circle <>----Points
 * author: Pablo Li
 */
namespace Points {
    class Point {
        private int x;
        private int y;
        public Point() { }                            // default c'tor
        public Point(int xx, int yy) {                // c'tor with 2 arguments
            x = xx;
            y = yy;
        }

        /*accessors*/
        public int getX() {
            return x;
        }
        public int getY() {
            return y;
        }

        /*mutators*/
        public void setX(int a) {
            x = a;
        }
        public void setY(int a) {
            y = a;
        }
        public int[] getXY() {                         // returns the x and y in a 2-element int array
            int[] temp = new int[2];
            temp[0] = x;
            temp[1] = y;
            return temp;
        }
        public void setXY(int a, int b) {
            x = a;
            y = b;
        }

        /*
         * distance returns the distance from this point to the given point
         * return distance
         */
        public double distance(int xx, int yy) {
            double temp = Math.Sqrt(Math.Pow((x - xx), 2) + Math.Pow((y - yy), 2));
            return temp;
        }

        /*
         * distance returns the distance from this point to the Object Point p
         * return distance
         */
        public double distance(Point p) {
            double temp = Math.Sqrt(Math.Pow((x - p.getX()), 2) + Math.Pow((y - p.getY()), 2));
            return temp;
        }

        /*
        * distance returns the distance from this point to 0
        * return distance
        */
        public double distance() {
            double temp = Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));
            return temp;
        }

        public void toString() {
            Console.WriteLine("The cordinate is: ({0},{1})", x,y);
        }


       
    }
    class Circle {

        private Point center;                                               // Aggregation relationship , Circle <>-------Points   (circle has points)
        private int radius = 1;
                                        
        public Circle() { }                                                 // default c'tor
        public Circle(int xx, int yy, int rds) {                            // c'tor with 3 arguments
            center = new Point(xx, yy);
            radius = rds;
        }
        public Circle(Point c, int rds) {                                   // c't with 2 argumetns
            center = c;
            radius = rds;
        }

        /*accessors*/
        public int getRadius() {
            return radius;
        }
        public Point getCenter() {
            return center;
            
        }
        public int getCenterX() {
            return center.getX();
            
        }
        public int getCenterY() {
            return center.getY();
        }

        public int[] getCenterXY() {
            return center.getXY();

        }

        /*mutator*/
        public void setRadius(int r) {
            radius = r;
        }
        public void setCenter(Point pt) {
            center = pt;
        }

        public void setCenterX(int a) {
            center.setX(a); 
        }

        public void setCenterY(int a) {
            center.setY(a);
        }

        public void setCeneterXY(int a, int b) {
            center.setXY(a,b);
        }

        public double getArea() {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double getCircumference() {
            return 2 * Math.PI * radius;
        }

    }
    class Program {                                                         // test class
        static void Main(string[] args) {
            Point p1 = new Point(3,4);            
            Console.WriteLine("distance is: {0} ",p1.distance(5,6) );       // method overloading, prints the distance from point A to the given point B

            Point p2 = new Point(7, 9);
            Console.WriteLine("distance is: {0}",p1.distance(p2));          // method overloading, prints the distance from this point to the given MyPoint instance

            Point p3 = new Point(10,11);
            Console.WriteLine("distance is: {0}",p3.distance());            // method overloading, prints the distance from this point to origin (0,0)

            /*test for accessors and mutators*/
            Point p4 = new Point(0,0); 
            p4.setX(12);
            p4.setY(13);
            Console.WriteLine("X is: {0} Y is: {1}",p4.getX(),p4.getY());

            /*test for accessors and mutators for Point []*/
            Point p5 = new Point();
            p5.setXY(14,15);
            Console.WriteLine("({0},y)",p5.getXY()[0]);                    // set x into array of int[0]
            Console.WriteLine("(x,{0})", p5.getXY()[1]);                   // set y into array of int[1]
            p5.toString();


            Circle c1 = new Circle(1,2,3);
       
            Console.WriteLine("area is: {0}", c1.getArea());
            Console.WriteLine("area is: {0}", c1.getCircumference());
            Console.WriteLine("Radius: {0}, center: {1}",c1.getRadius(),c1.getCenter());
          
            
        }
    }
}
