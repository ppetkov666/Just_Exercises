namespace _01___First_Task
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Bank
    {
        private AccountManager accountManager;

        public Bank()
        {
            this.accountManager = new AccountManager();
        }

        public string GetAccountBalance()
        {

            //return accountManager.Account.Ballance.ToString("f2");
            return accountManager.GetBalanceInCents().ToString("f2");

        }
    }
}
