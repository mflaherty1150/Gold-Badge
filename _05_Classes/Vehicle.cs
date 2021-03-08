using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, SUV, Motorcycle, Semi, Van, Spaceship, Boat, Plane }

    public class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool IsRunning { get; private set; }
        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public Vehicle() { }

        public Vehicle(string make, string model) 
        {
            Make = make;
            Model = model;
        }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        Vehicle myNewVehicle = new Vehicle();
        

        public void TurnOn()
        {
            IsRunning = true;
        } 

        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle.");
            IsRunning = false;
        }

        public int ReturnVehicleYear()
        {
            return Year;
        }

        public void IndicateRight()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }

        public void IndicateLeft()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }

        public void TurnOnHazards()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOn();
        }

        public void ClearIndicators()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOff();
        }

    public class Indicator
        {
            public bool IsFlashing { get; private set; }

            public void TurnOn()
            {
                IsFlashing = true;
            }

            public void TurnOff()
            {
                IsFlashing = false;
            }
        }
    }

}
