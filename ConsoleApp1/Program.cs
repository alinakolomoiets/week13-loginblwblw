using System;

namespace kolomoietstTARpv21
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string password = "pass1234";
            string userName, userPasword;

            int tries = 0;

             while(tries!=3)
            {
                Console.WriteLine("Enter yout login:");
                userName = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                userPasword = Console.ReadLine();

                if (login != userName || password != userPasword)
                {
                    Console.WriteLine("Oops.Somthing went wrong");
                    tries++;//tries=tries+1
                    Console.WriteLine($"Login failed.Attempts left{tries}");
                }
                else
                {
                    Console.WriteLine("Welcome");
                }
            }


            

        }

    }
}

