using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheritance
{
    internal class Car:Transport
    {
       public string Type { get; set; }
       public string Name { get; set; }

       public Car(int maxSpeed, int maxCapacity, string name, string type)
       {
           Type=type;
           Name=name;
       }

        public override void Move()
        {
            Console.WriteLine($"We are moving on {Type } {Name}the Highway to Hell at {MaxSpeed}");
        }
    }
}
