using System;
using System.Collections.Generic;
using System.Text;
namespace lab3
{
    class MyClass
    {


        public int[,,] array;



        public int Min2(int y)
        {


            int min = array[0, 0, 0];

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    for (int k = 0; k < y; k++)
                    {

                        if (min > array[i, j, k])
                        {
                            min = array[i, j, k];


                        }
                    }
                }
            }




            return min;


        }

        public int Min(int y)
        {


            int min = array[0, 0, 0];

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    for (int k = 0; k < y; k++)
                    {

                        if (min > array[i, j, k])
                        {
                            min = array[i, j, k];


                        }
                    }
                }
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    for (int k = 0; k < y; k++)
                    {



                        if (array[i, j, k] == min)
                        {
                            Console.Write($"[{i} {j} {k}] ");


                        }


                    }
                }
            }


            return min;


        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            int min_number = 0;

            const int size = 2;
            MyClass[] f = new MyClass[size];

            // int [,,] myarray = new int[3,3,3];
            for (int x = 0; x < size; x++)
            {
                f[x] = new MyClass();
                int[,,] myarray = new int[2, 2, 2];
                Console.WriteLine($"________________________________________________________________");
                Console.WriteLine($"Array :{x + 1}");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            myarray[i, j, k] = new int();
                        }
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            myarray[i, j, k] = random.Next(5, 50);
                        }
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("\n" + "Side № " + (i + 1) + "\n");
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            Console.Write(myarray[i, j, k] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                f[x].array = myarray;
                Console.WriteLine($"min  : {f[x].Min(2)}");
            }
            int min = f[0].Min2(2);
            for (int i = 0; i < size; i++)
            {
                if (f[i].Min2(2) > min)
                {
                    min = f[i].Min2(2);
                    min_number = i;



                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Result = : {(min_number + 1)}");

        }
    }
}