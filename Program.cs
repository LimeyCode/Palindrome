edusing System;

namespace Human_Computer_Interaction_Program
{
    class Program
    {
        /// <summary>
        /// This algorithm checks to see if a word inputted by the user is a Palidrome.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //The Variables Operate as followed:
            //String x holds is the user's word
            string x;
            //Boolean f tells if the program if the word is a Palidrome
            bool f;
            //Integer a is the start pointer for the word
            int a;
            //Integer z is the end pointer for the word
            int z;
            //Integer g holds the length of the word
            int g;

            x = Console.ReadLine();
            g = x.Length;
            z = g - 1;
            a = 0;
            //Intial check to see if the inputted word is a similar character
            if (g == 1)
            {
                f = true;
            }
            else
            {
                f = true;
                while (f == true && a < z)
                {
                    //Special characters and spaces don't contribute towards the word being a paildrome and so get skipped
                    while (x[a] == ' ' || x[a] == ',' || x[a] == ';' || x[a] == '!' || x[a] == '?' || x[a] == '.')
                    {
                        a++;
                    }

                    while (x[z] == ' ' || x[z] == ',' || x[z] == ';' || x[z] == '!' || x[z] == '?' || x[z] == '.')
                    {
                        z--;
                    }

                    if (x[a] == x[z])
                    {
                        a++;
                        z--;
                    }

                    else
                    {
                        f = false;
                    }

                }

            }
            if (f == false)
            {
                Console.WriteLine("This is not a palindrome");
            }

            else
            {
                Console.WriteLine("This is a palindrome");
            }

            Console.ReadKey();
        }
    }
}
