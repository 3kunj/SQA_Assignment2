using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define varibale for input
            string value1 = "";
            string choice = "";
            int select = 0;
            //for dimensions 
            int line1=0, line2=0, line3=0;



            do
            {
                //menu
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");

                choice = Console.ReadLine();

                if (Int32.TryParse(choice, out int c) || c > 0)
                {
                    select = c;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
               

                switch (select)
                {
                    case 1:
                        //get dimensions size
                        do
                        {
                            Console.WriteLine("Please Enter Dimension 1:");
                            value1 = Console.ReadLine();

                            if (Int32.TryParse(value1, out int l) || l > 0)
                            {
                                line1 = l;
                            }
                            else
                            {
                                Console.WriteLine("Invalid dimensions. Please Enter positive integer value. Zero is not acceptable.");
                            }
                        }
                        while (!Int32.TryParse(value1, out int l1) || !(l1 > 0));

                        do
                        {
                            Console.WriteLine("Please Enter Dimension 2:");
                            value1 = Console.ReadLine();

                            if (Int32.TryParse(value1, out int l) || l > 0)
                            {
                                line2 = l;
                            }
                            else
                            {
                                Console.WriteLine("Invalid dimensions. Please Enter positive integer value. Zero is not acceptable.");
                            }
                        }
                        while (!Int32.TryParse(value1, out int l1) || !(l1 > 0));

                        do
                        {
                            Console.WriteLine("Please Enter Dimension 3:");
                            value1 = Console.ReadLine();

                            if (Int32.TryParse(value1, out int l) || l > 0)
                            {
                                line3 = l;
                            }
                            else
                            {
                                Console.WriteLine("Invalid dimensions. Please Enter positive integer value. Zero is not acceptable.");
                            }
                        }
                        while (!Int32.TryParse(value1, out int l1) || !(l1 > 0));
                        //get answer from triangleSolver class
                        string answer = TriangleSolver.Analyze(line1, line2, line3);

                        Console.WriteLine(answer);

                        break;
                    
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            while (!(select == 2));





        }
    }
}
