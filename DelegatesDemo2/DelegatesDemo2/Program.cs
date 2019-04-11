using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo2
{
    class MyDelClass
    {

        public string India(double productPrice)
        {
            return (productPrice + (0.1 * productPrice)).ToString();
        }
        public string America(double productPrice)
        {
            return (productPrice + (0.15 * productPrice)).ToString();
        }
        public string China(double productPrice)
        {
            return (productPrice + (0.05 * productPrice)).ToString();
        }

    }
    class Program
    {
        public delegate string MyDelegate(double productPrice);
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                Console.WriteLine("Enter Product Price");
                double productPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Country");
                Console.WriteLine("1.India");
                Console.WriteLine("2.America");
                Console.WriteLine("3.China");
                int country = int.Parse(Console.ReadLine());
                MyDelClass myDel = new MyDelClass();
                switch (country)
                {
                    case 1:
                        MyDelegate myDel1 = myDel.India;
                        Console.WriteLine("For India the total amount is :" + myDel1(productPrice));
                        break;

                    case 2:
                        myDel1 = myDel.America;
                        Console.WriteLine("For America the total amount is :" + myDel1(productPrice));
                        break;

                    case 3:
                        myDel1 = myDel.China;
                        Console.WriteLine("For China the total amount is :" + myDel1(productPrice));
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("Press * to Exit");
                string status = Console.ReadLine();
                if (status.Equals("*"))
                {
                    flag = true;
                }
            } while (flag == false);
           

        }
    }
}
