using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Temperatur
    {
        private string _maxTemperatur = string.Empty;
        private string _minTemperatur = string.Empty;

        public string MaxTemperatur 
        { 
            get
            {
                return _maxTemperatur;
            } 
            set
            {

            }
        }

        public string MinTemperatur
        {
            get
            {
                return _minTemperatur;
            }
            set
            {

            }
        }
    }
}
