using System;

namespace CAReflection
{
    public class BankAccount
    {
        private string accountNo;
        private string holder;
        private decimal balance;

        public string AccountNo => accountNo;
        public string Holder => holder;
        public decimal Balance => balance;

        public event EventHandler OnNegativeBalance;
        public BankAccount()
        {

        }
        public BankAccount(string accountNo, string holder, decimal balance)
        {
            this.accountNo = accountNo;
            this.holder = holder;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
            if (this.balance < 0)
                this.OnNegativeBalance.Invoke(this, null);
        }

        public override string ToString()
        {
            return $"{{ Account No.: {accountNo}, Holder: {holder}, Balance: ${balance}}}";
        }

    }
}
