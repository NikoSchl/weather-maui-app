using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Helpers;
using WeatherApp.Collections;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class RiskOfRainModel : NotifyPropertyBase
    {
        private static readonly Random _random = new Random();

        private float _rainRiskInProzent = 0;

        private ImageSource _imageRainRisk = ImageSource.FromFile("regenschirm.png");


        public ImageSource ImageRainRisk
        {
            get { return _imageRainRisk; }
            set { _imageRainRisk = value;}
        }


        public float RainRiskInProzent
        {
            get { return _rainRiskInProzent; }
            set
            {
                if(_rainRiskInProzent != value)
                {
                    _rainRiskInProzent = value;
                    OnPropertyChanged(nameof(RainRiskInProzent));
                }
            }
        }

        //   ------------------ Konstruktoren ------------------ //

        public RiskOfRainModel()
        {
        }

        public RiskOfRainModel(int rainRiskInProzent)
        {
            RainRiskInProzent = rainRiskInProzent;
        }



        //   ------------------ Methoden zum generieren von Mockup Daten ------------------ //

        public static RiskOfRainModel GenerateRiskOfRain()
        {
            var riskOfRain = new RiskOfRainModel();
            riskOfRain.RainRiskInProzent = _random.Next(1, 100);
            riskOfRain.ImageRainRisk = ImageSource.FromFile("regenschirm.png");
            return riskOfRain;
        }
    }
}
