using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DMV_GUI.MotorVehicle> list = new List<DMV_GUI.MotorVehicle>(); //Using list instead of fixed array
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2013, 6, 5, 12, 30, 15)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2008, 12, 3, 19, 27, 03)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2005, 9, 12, 15, 03, 47)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2001, 3, 5, 02, 0, 0)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2013, 6, 5, 12, 30, 16)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2011, 5, 8, 19, 15, 01)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2010, 9, 5, 23, 27, 13)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2013, 5, 8, 08, 59, 57)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2004, 3, 6, 10, 45, 56)));
            list.Add(new DMV_GUI.MotorVehicle("VIN", "Make", "Model", 4, 5, new DateTime(2007, 11, 7, 13, 15, 28)));
            Console.WriteLine("Before sorting: ");
            foreach (DMV_GUI.MotorVehicle l in list)
                            {
                Console.WriteLine(l.show()); //Prints all information before dateOfProduction sorting
            }
            list.Sort(); //Sorts list
            Console.WriteLine("After sorting: ");
            foreach (DMV_GUI.MotorVehicle l in list)
            {
                Console.WriteLine(l.show()); //Prints information after sorting
            }
        }
    }
}
