using System;
using System.Collections.Generic;
using System.Text;
/* Rameswari Bhoi,
 Desc: Currency converter is taken from the https://gbp.currencyrate.today/usd
to getting the exchange rate and then convert from one currency to another currency
Date: 16/7/2021  */
namespace Project_420_WebApp
{
    class CurrencyConverter
    {
        public CurrencyConverter() { }// default constructor
        public double convert(string fromCurr, string toCurr, double value)
        {
            double tmpValue;
            switch (fromCurr)
            {
                case "CAD":
                    tmpValue = value / 1.26;
                    break;
                case "USD":
                    tmpValue = value / 1;
                    break;
                case "EURO":
                    tmpValue = value / 0.84;
                    break;
                case "GBP":
                    tmpValue = value / 0.72;
                    break;
                case "INR":
                    tmpValue = value / 74.63;
                    break;
                default:
                    tmpValue = value;
                    break;
            }

            switch (toCurr)
            {
                case "CAD":
                    tmpValue = 1.26 * tmpValue;
                    break;
                case "USD":
                    tmpValue = 1 * tmpValue;
                    break;
                case "EURO":
                    tmpValue = 0.84 * tmpValue;
                    break;
                case "GBP":
                    tmpValue = 0.72 * tmpValue;
                    break;
                case "INR":
                    tmpValue = 74.63 * tmpValue;
                    break;
                default:
                    break;
            }
 
            return Math.Round(tmpValue,3);
        }
    }
}
