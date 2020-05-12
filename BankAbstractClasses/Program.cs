using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAbstractClasses
{
    public interface IAccount
    {
        //void PayInFunds(decimal amount);
        //bool WithdrawFunds(decimal amount);
        decimal GetBalance();
        string RudeLetterString();
    }

    public abstract class Account:IAccount
    {
        private decimal balance = 0;

        public abstract string RudeLetterString();//abstract=will be described+implemented in child classes
                                                  //different way in each child class
        public decimal GetBalance()
        { return balance; }
    }

    public class CustomerAccount:Account
    {
        public override string RudeLetterString ()
        {
            string str ="";

            Console.WriteLine("you account is overdrawn!");
            return str;  
        }
    }

    public class BabyAccount : Account, IAccount
    {
        public override string RudeLetterString()
        {
            string str = "";

            Console.WriteLine("you BabyAccount is overdrawn!");
            return str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            const int MAX_CUST = 100;

            IAccount[] accounts = new IAccount[MAX_CUST];
            accounts[0] = new CustomerAccount();
            accounts[0].RudeLetterString();

            accounts[1] = new BabyAccount();
            accounts[1].RudeLetterString();

            Console.ReadKey();
        }
    }
}
