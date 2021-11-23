using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // login:admin
            //password:pass

            //declare veriables
            //assign value 
            string login = "admin";
            string password = "pass1234";

            string userName, userPasword;
            Console.WriteLine("Enter yout login:");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            userPasword = Console.ReadLine();

            if(login== userName&& password ==userPasword)
            {
                Console.WriteLine("Welccome");
            }
            else
            {
                Console.WriteLine("Oops. Something went wrong.");
            }
        }

    }
