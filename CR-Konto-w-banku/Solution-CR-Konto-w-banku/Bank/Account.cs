namespace Bank
{
    public class Account : Object, IAccount
    {
        protected const int DECIMAL_PRECISION = 4;
        public string Name { get; }
        public decimal Balance { get; private set; }
        public bool IsBlocked { get; private set; } = false;

        public Account(string name, decimal startingBalance = 0)
        {
            if (name == null || startingBalance < 0)
                throw new ArgumentOutOfRangeException();
            Name = name;
            Name = name.Trim();
            if (Name.Length < 3)
                throw new ArgumentException();
            Balance = Math.Round(startingBalance, DECIMAL_PRECISION);
        }

        public void Block() => IsBlocked = true;
        public void Unblock() => IsBlocked = false;



        public bool Deposit(decimal amount)
        {
            if (IsBlocked || amount <=0 ) return false;

            Balance += Math.Round(amount, DECIMAL_PRECISION);
            return true;
        }

        public bool Withdrawal(decimal amount)
        {
            if (IsBlocked || Balance < amount || amount <=0) return false;

            Balance -= Math.Round(amount, DECIMAL_PRECISION);
            return true;
        }

        override public string ToString()
        {
            return  (!IsBlocked) ? 
                        $"Account name: {Name}, balance: {Balance:F2}" : $"Account name: {Name}, balance: {Balance:F2}, blocked";
        }

    }
}
