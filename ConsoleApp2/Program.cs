using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int i = 3000, j = 2000, k = 1000;
        public static void Thread1()
        {
            while (true)
            {
                Thread t1 = new Thread(Program.GoodMorning);
                t1.Start();
                Thread.Sleep(3000);
                Thread t2 = new Thread(Program.Hello);
                t2.Start();
                Thread.Sleep(2000);
                Thread t3 = new Thread(Program.Welcome);
                t3.Start();
                Thread.Sleep(1000);

            }

        }
        
        public static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }             
        public static void Welcome()
        {
            Console.WriteLine("Welcome");
        }



        static void Main(string[] args)
        {
            Thread t1 = new Thread(Program.Thread1);
            t1.Start();

        }
    }
}
