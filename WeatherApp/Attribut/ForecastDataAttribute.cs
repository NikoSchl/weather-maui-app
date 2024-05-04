using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Attribut
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ForecastTableAttribute : Attribute
    {
        public string? Name { get; set; } = string.Empty;

        public ForecastTableAttribute()
        {
        }

        public ForecastTableAttribute(string name) 
        {
            Name = name;
        }
    }



    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ForecastColumnAttribute : Attribute
    {
        public string? Name { get; set; } = string.Empty;

        public string? DbTyp { get; set; } = string.Empty;

        public ForecastColumnAttribute()
        {
        }

        public ForecastColumnAttribute(string name, string dbTyp)
        {
            Name = name;
            DbTyp = dbTyp;
        }
    }
}
