using System;
using System.Collections.Generic;
using System.Text;
namespace lab4
{
    public class Area
    {

        double x; double xi; double y; double yi; double a11;
        double a12; double a13; double a21; double a22; double a23;

        public void set(double x, double y, double a11, double a12, double a13, double a21, double a22, double a23)
        {

            this.x = x;
            this.y = y;
            this.a11 = a11;
            this.a12 = a12;
            this.a13 = a13;
            this.a21 = a21;
            this.a22 = a22;
            this.a23 = a23;
        }



        public void get(double x, double y, double a11, double a12, double a13, double a21, double a22, double a23)
        {
            Console.WriteLine("     AREA ");
            Console.WriteLine("here is X: " + x);
            Console.WriteLine("here is Y: " + y);
            Console.WriteLine("here is A11: " + a11);
            Console.WriteLine("here is A12: " + a12);
            Console.WriteLine("here is A13: " + a13);
            Console.WriteLine("here is A21: " + a21);
            Console.WriteLine("here is A22: " + a22);
            Console.WriteLine("here is A23: " + a23);


        }




        public Double resX(double xi, double x, double y, double a11, double a12, double a13)
        {
            xi = ((a11 * x) + (a12 * y) + a13);
            return xi;
        }

        public double resY(double yi, double x, double y, double a21, double a22, double a23)
        {
            yi = ((a21 * x) + (a22 * y) + a23);
            return yi;
        }


    }



    public class Space : Area
    {

        double x; double xi; double y; double yi; double a11;
        double a12; double a13; double a14; double a21; double a22; double a23; double a24;
        double z; double zi; double a31; double a32; double a33; double a34;

        public void set(double x, double y, double z, double a11, double a12, double a13, double a14, double a21, double a22, double a23, double a24, double a31, double a32, double a33, double a34)
        {

            this.x = x;
            this.y = y;
            this.z = z;
            this.a11 = a11;
            this.a12 = a12;
            this.a13 = a13;
            this.a14 = a14;
            this.a21 = a21;
            this.a22 = a22;
            this.a23 = a23;
            this.a24 = a24;
            this.a31 = a31;
            this.a32 = a32;
            this.a33 = a33;
            this.a34 = a34;

        }

        public void get(double x, double y, double z, double a11, double a12, double a13, double a14, double a21, double a22, double a23, double a24, double a31, double a32, double a33, double a34)
        {
            Console.WriteLine("\t");
            Console.WriteLine("\n     SPACE ");
            Console.WriteLine("here is X: " + x);
            Console.WriteLine("here is Y: " + y);
            Console.WriteLine("here is Z: " + z);
            Console.WriteLine("here is A11: " + a11);
            Console.WriteLine("here is A12: " + a12);
            Console.WriteLine("here is A13: " + a13);
            Console.WriteLine("here is A14: " + a14);
            Console.WriteLine("here is A21: " + a21);
            Console.WriteLine("here is A22: " + a22);
            Console.WriteLine("here is A23: " + a23);
            Console.WriteLine("here is A24: " + a24);
            Console.WriteLine("here is A31: " + a31);
            Console.WriteLine("here is A32: " + a32);
            Console.WriteLine("here is A33: " + a33);
            Console.WriteLine("here is A34: " + a34);


        }

        public Double resX(double xi, double x, double y, double z, double a11, double a12, double a13, double a14)
        {
            xi = ((a11 * x) + (a12 * y) + (a13 * z) + a14);
            return xi;
        }

        public double resY(double yi, double x, double y, double z, double a21, double a22, double a23, double a24)
        {
            yi = ((a21 * x) + (a22 * y) + (a23 * z) + a24);
            return yi;
        }

        public double resZ(double zi, double x, double y, double z, double a31, double a32, double a33, double a34)
        {
            zi = ((a31 * x) + (a32 * y) + (a33 * z) + a34);
            return zi;
        }




        public static void Main(string[] args)
        {

            Space space = new Space();
            double xi = 0, yi = 0, x = 0, y = 0, z = 0, zi = 0, a11 = 0, a12 = 0, a13 = 0, a14 = 0, a21 = 0, a22 = 0, a23 = 0, a24 = 0, a31 = 0, a32 = 0, a33 = 0, a34 = 0;

            Random random = new Random();

            x = random.Next(1, 9);
            y = random.Next(1, 8);
            a11 = random.Next(1, 5);
            a12 = random.Next(1, 12);
            a13 = random.Next(1, 15);
            a14 = random.Next(1, 15);
            a21 = random.Next(1, 10);
            a22 = random.Next(1, 10);
            a23 = random.Next(1, 15);
            a24 = random.Next(1, 15);
            z = random.Next(1, 8);
            a31 = random.Next(1, 10);
            a32 = random.Next(1, 10);
            a33 = random.Next(1, 15);
            a34 = random.Next(1, 15);


            space.set(x, y, a11, a12, a13, a21, a22, a23);
            space.get(x, y, a11, a12, a13, a21, a22, a23);
            Console.WriteLine("\nResult: X' " + space.resX(xi, x, y, a11, a12, a13));
            Console.WriteLine("Result: Y' " + space.resY(yi, x, y, a21, a22, a23));

            space.set(x, y, z, a11, a12, a13, a14, a21, a22, a23, a24, a31, a32, a33, a34);
            space.get(x, y, z, a11, a12, a13, a14, a21, a22, a23, a24, a31, a32, a33, a34);
            Console.WriteLine("\nResult: X' " + space.resX(xi, x, y, z, a11, a12, a13, a14));
            Console.WriteLine("Result: Y' " + space.resY(yi, x, y, z, a21, a22, a23, a24));
            Console.WriteLine("Result: Z' " + space.resZ(zi, x, y, z, a31, a32, a33, a34));


        }
    }
}