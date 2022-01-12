using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    public abstract class Transport
    {
        public int MaxSpeed { get; set; }
        public int MaxCapacity { get; set; }
        protected Transport() { }

        protected Transport(int maxSpeed, int maxCapacity)
        {
            MaxSpeed=maxSpeed;
            MaxCapacity=maxCapacity;
        }
        public virtual void Move()
        {
            Console.WriteLine();
        }


    }
}
