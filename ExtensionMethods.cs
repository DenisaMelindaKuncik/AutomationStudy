using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationStudyGit
{
    public static class ExtensionMethods
    {
        public static string ToString(this Car car)
        {
            return "All the info of the car: \n" +
                "Make = " + car.Make + "\nModel = " + car.Model + "\nRegistration = " + car.Registration
                + "\nYear = " + car.ReturnCarYear() + "\nCurrent Value = " + car.ReturnCarCurrentValue();
        }
    }
}
