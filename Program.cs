using System;

namespace SimpleProgramGananFeb14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PUPBC SCHOOL ACCOUNT");

            string fname = "Clyza";
            string lname = "Ganan";
            string password = "092106";

            Console.Write("Enter first name: ");
            string fnameInput = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lnameInput = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwordInput = Console.ReadLine();

            if (fnameInput == fname && lnameInput == lname && passwordInput == password)
            {
                Console.WriteLine("Welcome to PUPBC!");
            }
            else
            {
                Console.WriteLine("Incorrect details. Try Again.");
            }
        }
    }
}
