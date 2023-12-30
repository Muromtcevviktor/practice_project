namespace ATMMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cardholder> cardHolders = new List<Cardholder>
            {
                new Cardholder("John", "Malkovic", "8712345678901234", 5683, (decimal)375.98),
                new Cardholder("Emma", "Thompson", "5432109876543210", 5984, (decimal)2140.00),
                new Cardholder("Olivia", "Rodriguez", "9876123456789012", 5984, (decimal)974.12),
                new Cardholder("Noah", "Patel", "1234987654321098", 7321, (decimal)48.22),
                new Cardholder("John", "Robinson", "5678901234567890", 3479, (decimal)1877.89)
            };

            Console.WriteLine("Welocme to ATM Machine");
            Console.WriteLine("Please insert your debit card: ");
            string cardNumber;
            Cardholder currentUser;

            while(true)
            {
                try
                {
                    cardNumber = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.CardNumber == cardNumber);
                    if(currentUser is not null )
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card with such number does not exist. Please enter correct number.");
                    }
                }
                catch
                {
                    Console.WriteLine("Card with such number does not exist. Please enter correct number.");
                }
            }


            Console.WriteLine("Please etner your PIN: ");
            int userPin;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.Pin == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN. Please try again.");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect PIN. Please try again.");
                }
            }

            Console.WriteLine($"Welcome, {currentUser.FirstName} ");
            int inputOption = 0;
            ATMMachine atmMachine = new ATMMachine();
            do
            {
                atmMachine.MenuOptions();
                try
                {
                    inputOption = int.Parse(Console.ReadLine());
                }
                catch{ }
                if(inputOption == 1)
                {
                    atmMachine.Deposit(currentUser);
                }
                else if(inputOption == 2)
                {
                    atmMachine.Withdraw(currentUser);
                }
                else if(inputOption == 3)
                {
                    atmMachine.Balance(currentUser);
                }
                else if (inputOption == 4)
                {
                    break;
                }
                else
                {
                    inputOption = 0;
                }
            }
            while (inputOption != 4);

            Console.WriteLine("Thank you! Good bye.");

        }
    }
}