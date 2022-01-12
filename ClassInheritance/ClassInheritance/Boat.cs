using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace ClassInheritance
{
    internal class Boat : Transport
    {
        public string Type { get; set; }

        public Boat(int maxSpeed, int maxCapacity, string type)
        {
            Type=type;
        }
       
        public override void Move()
        {

            Console.WriteLine("The boat is mooving");


        }

    }

    
    
}
