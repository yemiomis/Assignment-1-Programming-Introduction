using System;

namespace Assignment_1___Programming_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------Method 1--------------------------------------------------
            {
                Console.Write("please enter your inpts :");
                // This variable will gather data from user input
                string input_1 = Console.ReadLine();
                int n = Convert.ToInt32(input_1);
                PrintPattern(n);
                //-------------------------------------method 2--------------------------------------------------------
                Console.WriteLine("Please enter the number of terms of series");
                // This variable will gather data from user input
                string n_term = Console.ReadLine();
                int n2 = Convert.ToInt32(n_term);
                PrintSeries(n2);

            }
            //---------------------method 1----------------------------------------------------------------
            static void PrintPattern(int n)
            {

                for (int i = n; i >= 1; i--)
                {
                    Console.Write(i);


                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine("\n");
                }
            }
            //------------------------------method 2----------------------------------------------------
            static void PrintSeries(int n2)
            {
                int sum = 0;
                for (int i = 1; i <= n2; i++)
                {
                    sum = sum + i;
                    Console.Write(sum);
                    if (i < n2)
                    {
                        Console.Write(",");
                    }
                }
            }
 //------------------------- method 4-------------------------------------------------------------

            {
                //U 3
                //S 5 
                //F 7
                USFNumbers(110, 10);
                //---------------------------------


            }
            static void USFNumbers(int n, int k)
            {
                int ctr = 1;
                for (int i = 1; i <= n; i++)
                {
                    if ((i % 3 == 0) && (i % 5 == 0) && (i % 7 == 0))
                    {
                        Console.Write("USF");
                        Console.Write(",");
                    }
                    else if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        Console.Write("US");
                        Console.Write(",");
                    }
                    else if ((i % 3 == 0) && (i % 7 == 0))
                    {
                        Console.Write("UF");
                        Console.Write(",");
                    }
                    else if ((i % 5 == 0) && (i % 7 == 0))
                    {
                        Console.Write("SF");
                        Console.Write(",");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("U");
                        Console.Write(",");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("S");
                        Console.Write(",");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write("F");
                        Console.Write(",");
                    }
                    else
                    {
                        Console.Write(i);
                        Console.Write(",");
                    }
                    if (ctr == k)
                    {
                        ctr = 0;
                        Console.WriteLine("\n");
                        // Console.WriteLine("*********");
                    }
                    ctr++;
                }
            }
        }
    }
}

