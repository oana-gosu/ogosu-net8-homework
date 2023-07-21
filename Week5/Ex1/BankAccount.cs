using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex1
{
    public class BankAccount
    {
        public BankAccount(int AccountNumber, string AccountHolder, decimal Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
            Transactions = new List<Transactions>();
        }
        private int accountNumber { get; set; }
        public int AccountNumber 
        { 
            get { return accountNumber; }
            set { accountNumber=value; } 
        }
        private string accountHolder { get; set; }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        private decimal Balance { get; set; }
        public List<Transactions> Transactions { get; set; }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            Transactions myTrans = new Transactions();
            myTrans.TimeStamp = DateTime.Now;
            myTrans.Amount = amount;
            myTrans.Type = "";
            this.Transactions.Add(myTrans);
        }
        public void Withdraw(decimal amount)
        {
            Balance = Balance - amount;
            Transactions myTrans = new Transactions();
            myTrans.TimeStamp = DateTime.Now;
            myTrans.Amount = -amount;
            myTrans.Type = "";
            this.Transactions.Add(myTrans);

        }

        public decimal GetBalance()
        {
            return Balance;
        }
        public List<Transactions> GetTransactionsHistory()
        {
            return Transactions;
        }
     
    }

    public class Transactions
    {
        public DateTime TimeStamp { get; set; }
        public decimal Amount { get; set; }
        private string type;
        public string Type
        { get { return type; }
            set
            {
                if (Amount > 0) type = "Deposit";
                else type = "Withdraw";
            }
        }

       

    }
}
