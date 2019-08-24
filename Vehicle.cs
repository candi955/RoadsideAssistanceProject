using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectAAAGuide
{
    class Vehicle
    {
        // Fields
        private int doors;
        private int seating;
        private decimal fuel;
        private decimal rentalCost;
        private string channels;            
        private string color;
        private int speed;
        decimal actualDamage;
        decimal totalPossibleDamage;


          

        // Constructor: Physical
        public Vehicle()
        {
            doors = 0;
            seating = 0;
            fuel = 0;
            rentalCost = 0;
        }

        // Constructor: Color
        public Vehicle(string _color)
        {
            color = _color;
        }

        // Constructor Speed
        public Vehicle(int _speed)
        {
            speed = _speed;
        }



        // Constructors for Encapsulation: Total Possible Damage and actual Damage; attempting
        // to create the Constructors as both Read and Write - see the driver Damage class
        // No set value to 
        public decimal TotalPossibleDamage
        {
            get { return totalPossibleDamage; }
            set { totalPossibleDamage = value; }

        }

        public decimal ActualDamage
        {
            get { return actualDamage; }
            set { actualDamage = value; }
        }


        // Model properties

        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }

        public int Seating
        {
            get { return seating; }
            set { seating = value; }
        }

        public decimal Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public decimal RentalCost
        {
            get { return rentalCost; }
            set { rentalCost = value; }
        }
                                 
                       
        // Virtual Method for vehicle noises
       
        public virtual void vehicleTypeNoises()
        {
            
        }
    }
}

