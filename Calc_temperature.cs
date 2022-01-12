using System;
using System.Collections.Generic;
using System.Text;
using Project_420_WebApp;
/* Rameswari Bhoi,
 Desc: This temperature convert class is used for convert the temperature in to one format to another format and get a message on a particular temperrature.
Date: 16/7/2021  */
namespace Project_420_WebApp
{
    class Calc_temperature : valueInterface
    {
        private double value1;
        private double value2;
        private double result;
        private string desc;
        private Dictionary<double, string> messages = new Dictionary<double, string>(9);

        // getter and setter for values
        public double Value1 {
            get { return value1; }
            set {
                if (value >= 0)
                {
                    value1 = value;
                }
            }
        }
        public double Value2
        {
            get { return value2; }
            set
            {
                if (value >= 0)
                {
                    this.value2 = value;
                }
            }
        }

        public Double Result
        {
            get{return result;}
            set
            {
                if (value >= 0)
                {
                    this.result = value;
                }
            }
        }
        public string Desc
        {
            get {
                messages.TryGetValue((int)value1, out string desc);
                return desc;
            }
           
        }
        // constructor
        public Calc_temperature() {
            messages.Add(100, "Water boils");
            messages.Add(40, "Hot Bath");
            messages.Add(37, "Body temperature");
            messages.Add(30, "Beach weather");
            messages.Add(21, "Room temperature");
            messages.Add(10, "Cool Day");
            messages.Add(0, "Freezing podouble of water");
            messages.Add(-18, "Very Cold Day");
            messages.Add(-40, "Extremely Cold Day\r\n(and the same number!)");
        } // default constructor

        // public methods
        public double calc_temp(double c_value,bool isCelcius) {
            value2 = 0;
            value1 = c_value;
            if (isCelcius)
            {
                result = (value1 * (9.0 / 5.0)) + 32;
            }
            else {
                result=(value1 - 32) * (5.0 / 9.0);
            }
            return Math.Round(result,2);
        }  
    }
}
