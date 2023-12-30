using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    internal class ATMMachine
    {
        public void MenuOptions()
        {
            Console.WriteLine("Please choose from one of the follwing options: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Exit");
        }

        public void Deposit(Cardholder currentUser)
        {
            Console.WriteLine("Please enter amount you want to deposit: ");
            decimal deposit = Decimal.Parse(Console.ReadLine());
            if(deposit <= 0)
            {
                Console.WriteLine("Cannot deposit such amount. Please enter number above 0");
            }
            else
            {
                currentUser.Balance += deposit;
                Console.WriteLine($"Thank you for your deposit. Your current balance is {currentUser.Balance}");
            }
        }

        public void Withdraw(Cardholder currentUser)
        {
            Console.WriteLine("Please enter amount you want to withdraw: ");
            decimal widthdrawal = Decimal.Parse(Console.ReadLine());
            if(currentUser.Balance < widthdrawal) 
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                currentUser.Balance -= widthdrawal;
                Console.WriteLine($"Widthdrawal was successfull. Your current balance is {currentUser.Balance}");
            }
        }
        public void Balance(Cardholder currentUser)
        {
            Console.WriteLine($"Your current balance is: {currentUser.Balance}");
        }
    }
}
