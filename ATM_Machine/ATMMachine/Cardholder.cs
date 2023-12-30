
namespace ATMMachine
{
    internal class Cardholder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public int Pin { get; set; }
        public decimal Balance { get; set; }

        public Cardholder(string firstName, string lastName, string cardNumber, int pin, decimal balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }
    }
}
