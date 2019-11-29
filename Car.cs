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
            FabricationYear = vehicleModel.FabricationYear;
            CurrentValue = vehicleModel.CurrentValue;
        }
        public Car(string make, string model, string registration, string fabricationYear, int currentValue)
        {
            Make = make;
            Model = model;
            Registration = registration;
            FabricationYear = fabricationYear;
            CurrentValue = currentValue;
        }

        public int ReturnCarCurrentValue()
        {
            return CurrentValue;
        }

        public string ReturnCarYear()
        {
            return FabricationYear;
        }
    }
}

