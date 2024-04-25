using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.ViewModels
{
    public class SevenDayViewModel
    {
        private string test = string.Empty;

        public string Test
        {
            get { return test; }
            set
            {
                test = value;
                Debug.WriteLine(value);
            }
        }
    }
}
