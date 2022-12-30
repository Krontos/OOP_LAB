using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace ConsoleApplication1
{
    class ThreeMass
    {
        public int r;

        public int Print(ThreeMass[,,] array, int y)
        {
            int min = array[0, 0, 0].r;

            for (int a = 0; a < y; a++)
            {
                for (int b = 0; b < y; b++)
                {
                    for (int c = 0; c < y; c++)
                    {
                        if (min > array[a, b, c].r)
                        {
                            min = array[a, b, c].r;
                        }
                    }
                }
            }
            return min;
        }
            static void Main(string[] args)
            {
                Random rand = new Random();
                ThreeMass[,,] myarray = new ThreeMass[3, 3, 3];
                ThreeMass f = new ThreeMass();

                for (int a = 0; a < 3; a++)
                {
                    for (int b = 0; b < 3; b++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            myarray[a, b, c] = new ThreeMass();
                        }
                    }
                }

                for (int a = 0; a < 3; a++)
                {
                    for (int b = 0; b < 3; b++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            myarray[a, b, c].r = rand.Next(250);
                        }
                    }
                }

                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine("\n" + "Side # " + (a + 1) + "\n");

                    for (int b = 0; b < 3; b++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                                Console.WriteLine(myarray[a, b, c].r + " ");
                        }
                        Console.WriteLine();
                    }
                }
                
                Console.WriteLine("\nResult: " + f.Print(myarray, 3));
            
            }   
        
    }


}