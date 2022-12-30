using System;
using System.Text.RegularExpressions;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string s = Console.ReadLine();
            Regex regex = new Regex(@"Kostya(\w*)");
            MatchCollection matches = regex.Matches(s);
            Console.WriteLine("\n");
            if (matches.Count > 0)
            {
                foreach(Match match in matches)
                {
                    Console.WriteLine(match.Value + "\n");
                    count++;
                }
                Console.WriteLine("l found it");
                Console.WriteLine("Number of words is: " + count);
            }
            else
            {
                Console.WriteLine("Sorry, l didn't find it");
            }
        }
    }
                
}