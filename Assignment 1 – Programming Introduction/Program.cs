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

                //---------------------------------------method 4
                //U 3
                //S 5 
                //F 7
                USFNumbers(110, 10);
                //......................................method 5...............................................
                string m = "ssslllls";
                Console.WriteLine(PalindromeCheck(m));
                string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
                PalindromePairs(words);

            }
            {
                //---------------------method 1----------------------------------------------------------------
                private static void PrintPattern(int n)
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
                public static void PrintSeries(int n2)
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

                //--------------------method 3 -----------------------------------------------------


                public static string usftime(string s)
                {
                    try
                    {

                        // earth date input
                        Console.WriteLine("enter the date of earth with the format of hh:mm:ssam or hh:mm:sspm: ");
                        string earth_date_input = Console.ReadLine();
                        DateTime dateofearth = Convert.ToDateTime(earth_date_input);

                        // calculateions
                        int entered_hours = dateofearth.Hour;
                        int entered_minutes = dateofearth.Minute;
                        int entered_seconds = dateofearth.Second;

                        //var enteredispm = (dateofearth.hour >= 12);

                        /*int enteredispm = 0;
                        if (dateofearth.hour >= 12)
                            enteredispm = 1;
                        else
                            enteredispm = 0;
                       */
                        // total seconds of dateofearth
                        int totalsecofearth = entered_hours * 3600 + entered_minutes * 60 + entered_seconds;

                        // calculate the date of usf
                        int usfhours = totalsecofearth / (60 * 45);
                        int usfminutes = (totalsecofearth - usfhours * (60 * 45)) / 45;
                        int usfseconds = totalsecofearth - usfhours * (60 * 45) - usfminutes * 45;

                        //datetime usfdate = new datetime(0, 0, 0, usfhours, usfminutes, usfseconds);
                        int[] usfdate = new int[] { usfhours, usfminutes, usfseconds };


                        Console.WriteLine("usf format: " + string.Join(":", usfdate));

                        Console.WriteLine();

                    }
                    catch
                    {
                        Console.WriteLine("exception occured while computing usftime");
                    }
                    return null;
                }
                //------------------------- method 4-------------------------------------------------------------

                {

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
                //-----------------------------method 5----------------------------------------
                public static void PalindromePairs(string[] words)
                {
                    int length = words.Length;
                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            string joint = words[i] + words[j];
                            bool outputPalindrome = PalindromeCheck(joint);
                            if (outputPalindrome == true)
                            {
                                Console.WriteLine("output array index - [{0},{1}]", i, j);
                                Console.WriteLine("\n");
                            }
                        }
                        //string m = words[i];

                    }
                }
                public static bool PalindromeCheck(string s)
                {
                    int a = 0;
                    int b = s.Length - 1;
                    //This loop checks the string input from both ends like starting end and ending end
                    while (true)
                    {
                        if (a > b)
                        {
                            return true;
                        }
                        char m = s[a];
                        char n = s[b];
                        //This condition checks whether two strings created in above are equal or not
                        if (char.ToLower(m) != char.ToLower(n))
                        {
                            return false;
                        }
                        a++;
                        b--;
                    }
                    //
                    /*bool ans = false;
                    for (int i = 0; i < m.Length; i++)
                    {
                        if(m[i] == m[m.Length - 1 - i])
                        {
                            ans = true;
                        }
                        else
                        {
                            ans = false;
                        }
                    }
                    return ans;*/
                }
            }
        }




