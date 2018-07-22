namespace _01___First_Task
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class AccountManager : IAccountManager
    {
        public BankAccount Account { get; private set; }

      

        public int GetBalanceInCents()
        {
            return 0;

        }
    }
}
