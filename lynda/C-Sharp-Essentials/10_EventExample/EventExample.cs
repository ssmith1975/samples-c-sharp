using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_EventExample
{
    // Event Example

    // Delegate
    public delegate void myEventHandler(string newValue); // Declared in namespace

    class EventConsumer
    {// Raises events for others to listen to 
        private string theValue;

        // Delare event
        public event myEventHandler valueChanged;

        public string Val
        {
            set
            {
                this.theValue = value;
                this.valueChanged(this.theValue); // trigger event;
            }
        }

    }
 
    class EventExample
    {
        // Event Listener
        static void myEvt_valueChanged(string newValue)
        {
            Console.WriteLine("The value changed to {0}", newValue);
        }

        static void Main(string[] args)
        {
            EventConsumer myEC = new EventConsumer();
            myEC.valueChanged += new myEventHandler(myEvt_valueChanged); // Subscribe to event
            string str;

            do
            {
                str = Console.ReadLine();

                if (!str.Equals("exit"))
                    myEC.Val = str;
            } while (!str.Equals("exit"));


        }
    }
}
