namespace _01___First_Task
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            
            IBankAccount bankaccount = new BankAccount(50);
            Console.WriteLine(bankaccount.Balance);
            IAccountManager accManager = new AccountManager();
            Console.WriteLine(accManager.GetBalanceInCents());
        }
    }
}
