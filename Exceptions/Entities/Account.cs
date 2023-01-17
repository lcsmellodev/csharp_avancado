using Exceptions.Entities.Exceptions;
using System.Globalization;

namespace Exceptions.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double Amount)
        {
            Balance += Amount;
        }

        public void WithDraw(double Amount)
        {
            
            if(Amount >= WithDrawLimit)
            {
                throw new WithDrawLimitException("The amount exceeds withdraw limit");
            }
            else if (Amount > Balance)
            {
                throw new InsufficientBalanceException("Not enough balance");
            }

            Balance -= Amount;
        }

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
