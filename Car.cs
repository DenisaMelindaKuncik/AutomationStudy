using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationStudyGit
{
    public class Car : Vehicle
    {
        public Car(Vehicle vehicleModel)
        {
            Make = vehicleModel.Make;
            Model = vehicleModel.Model;
            Registration = vehicleModel.Registration;
            Year = vehicleModel.Year;
            CurrentValue = vehicleModel.CurrentValue;
        }
        public Car(string make, string model, string registration, string year, int currentValue)
        {
            Make = make;
            Model = model;
            Registration = registration;
            Year = year;
            CurrentValue = currentValue;
        }

        public int ReturnCarCurrentValue()
        {
            return CurrentValue;
        }

        public string ReturnCarYear()
        {
            return Year;
        }
    }
}

