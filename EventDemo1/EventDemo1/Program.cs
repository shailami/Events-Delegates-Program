using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo1
{
    //defining delegate for Event handler
    public delegate void myEventHandler(string value);
    class EventPublisher
    {
        private string theVal;
        //declare the event
        public event myEventHandler valueChanged;

        public string Val
        {
            set
            {
                this.theVal = value;
                //when value changes fire the event
                this.valueChanged(theVal);
            }
        }

    }
    class Program
    {   
        static void Main(string[] args)
        {
            EventPublisher obj = new EventPublisher();
            obj.valueChanged += new myEventHandler(obj_valueChanged);
            string str;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            obj.Val = str;
            Console.ReadKey();
            
        }
        static void obj_valueChanged(string value)
        {
            Console.WriteLine("The value changed to {0}",value); 
        }
    }
    
}
