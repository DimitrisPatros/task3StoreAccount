namespace task3StoreAccount.models
{
    class StoreAccount : Account
    {
       
        string _storeName;
        string _accountCategory;

        public StoreAccount(){}
        
        public StoreAccount(string owner, double balance, int numberOfTransaction, 
            string storeName, string accountCategory) : base( owner, balance, numberOfTransaction){
            _storeName = storeName;
            _accountCategory = accountCategory;
        }
        public override string ToString(){
            return base.ToString() +
                   "\nStore Name:       " + _storeName+
                   "\nAccount Category:" + _accountCategory;
        }
    }
}
