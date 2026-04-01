

namespace homework_5
{
    public class Customer
    {
        public string FullName {get; set;}
        public string CardNumber {get;}
        private string Pin;
        private decimal Balance;

        public Customer(string fullName, string cardNumber, string pin, decimal initialBalance)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = initialBalance;
        }

        public bool VerifyPin(string inputPin) => Pin == inputPin;

        public decimal GetBalance() => Balance;

        public void Deposit(decimal amount) => Balance += amount;

        public bool Withdraw(decimal amount)
        {
            if(amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

    }
}
