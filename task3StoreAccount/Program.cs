using System;
using task3StoreAccount.models;

namespace classProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doContinue;
            double amound;
            
            //Create new account
            Account customer = new Account("Dimitris", 400, 1);
            //Console.WriteLine(customer.ToString());
            Console.WriteLine("-----------------------");
            
            StoreAccount storeAccount = new StoreAccount("John", 600, 1," Peristeriou", "Tamieftirou");
            Console.WriteLine(storeAccount.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine("----------------------------");

            do
            {
                Console.WriteLine("press 'w' for withdraw  or 'd' for deposite");      


                char action;
                action = char.Parse(Console.ReadLine());
                if (action == 'w')
                {
                    Console.WriteLine("type the amount");
                    amound = double.Parse(Console.ReadLine());                    
                    bool success = storeAccount.Withdraw(amound);
                    if (success) Console.WriteLine("Withdrawal successfull :)");
                    else Console.WriteLine("Withdrawal unsuccessfull :(");
                }
                else if (action == 'd')
                {
                    Console.WriteLine("Type the amount");
                    amound = double.Parse(Console.ReadLine());
                    bool success = storeAccount.Deposit(amound);
                    if (success) Console.WriteLine("Deposite successfull :)");
                    else Console.WriteLine("Deposite unsuccessfull :(");
                }
                else
                {
                    Console.WriteLine("Wrong answer please try again 'w' for withdraw or 'd' for deposit");
                }
                Console.WriteLine(storeAccount.Balance());
                //Console.WriteLine(storeAccount.ToString());
                //Console.WriteLine(customer.ToString());


                Console.WriteLine("Do you want to do another job (y/n)");
                char response = char.Parse(Console.ReadLine());
                if (response == 'y')
                {
                    doContinue = true;
                }
                else
                {
                    doContinue = false;
                    Console.WriteLine("Goodbye");
                    Console.WriteLine(storeAccount.ToString());
                }

            } while (doContinue);

        }
    }//End of Class Program

}

