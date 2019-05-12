namespace task3StoreAccount.models
{

    class Account
    {
        //fields
        const double _depositeLimit = 5000;
        string _owner;
        double _balance;
        int _numberOfTransaction;

        //method for withdraw
        public bool Withdraw(double amound)
        {
            _numberOfTransaction++;
            if (_balance < amound) return false;
            _balance -= amound;
            return true;

        }

        //method for deposit
        public bool Deposit(double amound)
        {
            _numberOfTransaction++;
            if (amound > _depositeLimit) return false;
            _balance += amound;
            return true;

        }
        public string Balance()
        {
            return "The new Balance is : " + _balance;
        }

        //empty constructor
        public Account()
        {
        }

        //main constructor
        public Account(string owner, double balance, int numberOfTransaction)
        {
            _owner = owner;
            _balance = balance;
            _numberOfTransaction = numberOfTransaction;
        }

        //ToString 
        public override string ToString()
        {
            return "Owner:                 " + _owner +
                   "\nBalance:               " + _balance +
                   "\nNumber of Transaction: " + _numberOfTransaction;
        }

    }//End of Class Account 
    
}
