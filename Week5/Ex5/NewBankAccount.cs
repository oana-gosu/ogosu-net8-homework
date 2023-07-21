using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex5
{
    public class NewBankAccount 
    {
        private int accountNumber { get; set; }
        private string accountHolder { get; set; }
        private double balance { get; set; }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
     
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public double Balance
        { 
            get { return balance; } 
            set 
            {
                if (balance >= 0) balance = value;
                else throw new Exception("Balance not valid");
            } 
         
        }
        public NewBankAccount(int accountNumber, string accountHolder, double balance) 
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
        public void Withdraw (double amount)
        {
            if (Balance >= amount)
                Balance = Balance - amount;
            else throw new Exception("Not enough money");
        }

        //public double GetInterest()
        //{
        //    return CalculateInterest(Balance); //cum folosesc metoda din clasa static?
        //}
    }
}
