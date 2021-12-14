using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userBankAccount = new BankAccount();
            
            Menu(userBankAccount);
        }

        public static void Menu(BankAccount userBankAccount)
        {
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("Enter a number to select an option from the menu:");
            Console.WriteLine();
            Console.WriteLine("1. Make a deposit.");
            Console.WriteLine("2. Check your balance.");
            Console.WriteLine("3. Exit the program.");
            Console.WriteLine();
            
            string option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1")
            {
                Console.WriteLine("How much would you like to deposit?");
                Console.WriteLine();
                double deposit = Convert.ToDouble(Console.ReadLine());
                userBankAccount.Deposit(deposit);
                Console.WriteLine();
                Console.WriteLine($"${deposit} has been deposited to your account.");
                Console.WriteLine();
                Menu(userBankAccount);
            }
            else if (option == "2")
            {
                Console.WriteLine($"Your account balance is ${userBankAccount.GetBalance()}");
                Console.WriteLine();
                Menu(userBankAccount);
            }
            else if (option == "3")
            {
                Console.WriteLine("Have a great day!");
                // ends program
            }
            else
            {
                Menu(userBankAccount); //resets menu
            }

        }
    }
}
