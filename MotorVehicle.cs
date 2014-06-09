using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMV_GUI
{
    class MotorVehicle : IComparable
    {
        string VIN;
        string make;
        string model;
        DateTime dateOfProduction;
        protected int noOfWheels;
        protected int noOfSeats;
        protected char fieldSep = '|';
        public static int count = 0; //Integer static count
        public static string copyright = "Kerim Krdzevic"; //Integer static count

        public int CompareTo(object other) //Compare function
        {
            return this.dateOfProduction.CompareTo(((MotorVehicle)other).dateOfProduction); //CompareTo function dateOfProduction
        }

        public MotorVehicle(string VIN, string make, string model, int noOfWheels, int noOfSeats, DateTime dateOfProduction)
        {
            this.VIN = VIN;
            this.make = make;
            this.model = model;
            this.noOfSeats = noOfSeats;
            this.noOfWheels = noOfWheels;
            this.dateOfProduction = dateOfProduction;
            count++; //add count function for counting objects 
        }

        public virtual string show()
        {
            return string.Format(" Make: {1} {0} Model: {2} {0} Number of Wheels: {3} {0} Date of production: {4}", fieldSep, make, model, noOfWheels, dateOfProduction);
        }
    }
}
