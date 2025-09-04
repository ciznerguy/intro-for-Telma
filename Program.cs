
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro
{
    internal class Program
    {
       
        public static void Ex1()
        {
            Console.WriteLine("Hello World!");
        }
        public static void Ex2()
        { 
            Console.WriteLine("Hello peter parker!"); 
        }
        public static void Ex3()
        {
            int num = 100;
            double mispar = 123.45;
            Console.WriteLine($"the whole number is {num}");
            Console.WriteLine($"the other number is {mispar}");
        }
        public static void Ex4()
        {
            int num1 = 100;
            int num2 = 200;
            int sum = num1 + num2;
            Console.WriteLine($"the sum of {num1} and {num2} is {sum}");
        }
        public static void Ex5()
        {
            string name = "peter parker is number 1";
            string massage = "hello";
            Console.WriteLine($"{massage} and {name}");
        }
        //יש לכתוב תוכנית המגדירה שני משתנים
        //הראשון שער הדולר
        //השני מספר הדולרים שברצוננו להמיר
        //התוכנית תחשב ותדפיס כמה שקלים נקבל עבור הדולרים
        public static void Ex6()
        {
            double dollarRate = 3.5;
            double dollars = 100;
            double shekels = dollarRate * dollars;
            Console.WriteLine($"for {dollars} dollars you will get {shekels} shekels");
        }



        static void Main(string[] args)
        {
            Ex6();
        }
    }
}
