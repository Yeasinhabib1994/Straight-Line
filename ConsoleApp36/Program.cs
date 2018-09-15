using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a for y = a*x + b");
            string slope = Console.ReadLine();
            double a = Convert.ToDouble(slope);
            if (a == 0)
                throw new Exception("you can not put null for a");
            Console.WriteLine("input b for y = a*x + b");
            string constant = Console.ReadLine();
            double b = Convert.ToDouble(constant);

            for (int i = 0; i <= 30; i++)
            {
                if (i == 15)
                {
                    for (int j = 0; j < 120; j++)
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    int x = Convert.ToInt32((15 - i - b) / a);

                    if (x >= 0)
                    {
                        for (int k = 0; k < 119 - x; k++)
                        {
                            if (k == 59)
                            {
                                Console.Write(".");

                                for (int l = 0; l < x; l++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(".");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    else if(x < 0)
                    {
                        for (int k = 0; k < 120 ; k++)
                        { 
                            if (k <= 59)
                            {
                                if (k == 59 + x)
                                {
                                    Console.Write(".");
                                }
                                else if (k == 59)
                                {
                                    Console.Write(".");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
