using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_accessmods
{
    class Boat
    {
            public int numberOfPassengers;

            private string name;
            private double engineSize;

    public string Name
            {
                get { return name; }
                set { name = value; }
            }


            public Boat()
            {

            }

            public Boat(int numberOfPassengers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }
        
       
        

            public void Move()
            {
            Console.WriteLine(name + " moves forward");
            }

            private double CalculateMPG()
            {
            //code to calculate the MPG
            double MPG = engineSize * .7d;
                return MPG;
            }


            // This is what you were trying to do with the super hero!! all you have to do is declare the
            // variables in the program with the constructor and the information will show with this method 
        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine size: " + engineSize);
            Console.WriteLine("MPG: " + CalculateMPG());
            Console.WriteLine();
        }



    }
}
