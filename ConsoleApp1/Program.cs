using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        int i;
        Random random = new Random();

        public void create()
        {
            while (true)
            {
                i=random.Next(10,20);
                if ((i%2) == 0)
                {
                    Thread th1 = new Thread(Square);
                    th1.Start();
                }
                else
                {
                    Thread th2 = new Thread(Cube);
                    th2.Start();
                }
                Thread.Sleep(2000);
            }
            
        }


        public void Cube()
        {
            Console.WriteLine("Cube value of " + i + " is: " + (i * i * i));
        }
        public void Square()
        {
            Console.WriteLine("Square value of " + i + " is: " + (i * i));
        }

       

        static void Main(string[] args)
        {
            
            Program obj = new Program();
            Thread th = new Thread(obj.create);
            th.Start();
            

        }
    }
}
