//1.Create simple threaded application that prints out the name of a fruit at
//timed intervals.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {

        public static void Thread1()
        {
            while (true)
            {
                Console.WriteLine("Apple");
                Thread.Sleep(2000);
            }
            
        }

        

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Program.Threa);
            t1.Start();

        }
    }
    
    
    
    
    
    
    
    
    
    
    
    class Area
    {

        public int area(int len, int bre)
        {
            return len * bre;
        }

        public int area(int len)
        {
            return len * len;
        }

    }
    class Student2
    {
        string name;
        int age, eng, math, sci;

        public void assign()
        {
            Console.WriteLine("Enter the name of the student:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age of the student:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of subject math:");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of subject eng:");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of subject sci:");
            sci = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateTotalmarks()
        {
            return (math + eng + sci);
        }
        public float calculatePercentage()
        {
            float tot = math + eng + sci;
            // Console.WriteLine(tot);
            // Console.WriteLine(tot/300);
            float p = tot / 300;
            p *= 100;

            return p;
        }
    }

    class Student
    {
        int StudentId;
        String StudentName, DOB, CourseName;

        public Student(int StudentId, String StudentName, String CourseName, String DOB)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.CourseName = CourseName;
            this.DOB = DOB;
        }
        public void showStudent()
        {
            Console.WriteLine(StudentId + " " + StudentName + " " + CourseName + " " + DOB);
        }
    }

    class A
    {
        int i = 90;
        public virtual void show()
        {
            Console.WriteLine("The value of i is: " + i);
        }
    }

    class B : A
    {
        int j = 100;
        public override void show()
        {
            base.show();
            Console.WriteLine("The value of j is: " + j);
        }
    }
}
