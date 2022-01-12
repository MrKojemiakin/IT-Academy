using System;

namespace ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat(100, 5, "yacht");

            Car car = new Car(260,5,"TAXI","Hatchback");

            boat.Move();

            car.Move();

            
        }
    }
}
