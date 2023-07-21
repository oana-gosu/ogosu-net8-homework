using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex5
{
    static class Bank
    {
        static double  InterestRate { get; set; } //cum fac initiere??
        static int NumAccounts { get; set; }
        
        static double CalculateInterest(double balance)
        {
            return balance * InterestRate;
        }

        static int GetNumAccounts()
        {
            return NumAccounts;
        }
    }
}
