namespace _01___First_Task
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class BankAccount : IBankAccount
    {
        private int balance;
        public BankAccount(int balance)
        {
            this.balance = balance;
        }
        public int Balance
        {
            get => balance;
            set => value = balance;
        }
        
        

    }
}
