using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labday21_10_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new Bank();
            obj.Assign();
            obj.WithDraw();
            obj.Deposite();
            obj.ShowData();

        }
    }
    class Bank
    {
        string depositor;
        int AcNum, WiAm, Balance;

        public void Assign()
        {
            Console.WriteLine("Enter Depositor Name: ");
            this.depositor= Console.ReadLine();
            Console.WriteLine("Enter Account Number: ");
            this.AcNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Balance: ");
            this.Balance = Int32.Parse(Console.ReadLine());
      
        }
        public void Deposite()
        {
            Console.WriteLine("Enter Deposite Amount: ");
            int n = Int32.Parse(Console.ReadLine());
            this.Balance += n;
            int p = this.Balance;
            Console.WriteLine("Current Balance is: " + this.Balance);
        }

        public void WithDraw()
        {
            Console.WriteLine("Enter Withdraw Amount: ");
            this.WiAm = Int32.Parse(Console.ReadLine());
            this.Balance -= this.WiAm;
            Console.WriteLine("Balance after withdraw: " + this.Balance);
        }

        public void ShowData()
        {
            Console.WriteLine("Name of Depositor is: " + depositor);
            Console.WriteLine("Current Balance is: ");
        }


    }
}

