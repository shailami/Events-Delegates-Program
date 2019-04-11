using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo1
{  class MyNewDelegates
    {
        public string myClassDelegate(int arg1,int arg2)
        {
            return ((arg1*arg2)+arg1).ToString();
        }
    }
    
    
    //Declare Delegates
    public delegate string MyDelegate(int arg1, int arg2);
    class Program
    {
        //Implement delegate Function
        static string myFunc1(int num1,int num2)
        {
            return (num1 + num2).ToString();
        }
        static string myFunc2(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        static string myFunc3(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        static string myFunc4(int num1, int num2)
        {
            return (num1 / num2).ToString();
        }

        static void Main(string[] args)
        {
            //Calling static methods
            MyDelegate myDeg = myFunc1;
            Console.WriteLine("First function value is:" + myDeg(10, 20));
            myDeg = myFunc2;
            Console.WriteLine("Second function value is:" + myDeg(10, 20));
            myDeg = myFunc3;
            Console.WriteLine("Third function value is:" + myDeg(20, 10));
            myDeg = myFunc4;
            Console.WriteLine("Forth function value is:" + myDeg(20, 10));

            //Calling Class Methods
            MyNewDelegates myClass = new MyNewDelegates();

            myDeg = myClass.myClassDelegate;
            Console.WriteLine("My Class Delegate function value is:" + myDeg(10, 20));


            //Anonymous Delegates s
            MyDelegate myDel1 = delegate (int num1, int num2)
              {
                  return (num1 + num2).ToString();
              };
            Console.WriteLine("Anonymous Delegates : "+myDel1(10,20));

            Console.WriteLine("******************************");
            MyDelegate deg1 = myFunc1;
            MyDelegate deg2 = myFunc2;
            MyDelegate deg4 = myFunc3;
            MyDelegate deg3 = deg1+deg2+deg4;
           
            Console.WriteLine("Del1 Call value is"+deg1(10,20));
            Console.WriteLine("Del2 Call value is" + deg2(10, 20));
            Console.WriteLine("Del3 Call value is" + deg3(10, 20));
            Console.WriteLine("Del4 Call value is" + deg3(10, 20));

            Console.ReadKey();
        }
    }
}
