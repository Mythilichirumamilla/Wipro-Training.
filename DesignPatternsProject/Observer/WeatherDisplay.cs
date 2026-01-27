using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    public class WeatherDisplay : IWeatherObserver
    {
        private readonly string _name;

        public WeatherDisplay(string name)
        {
            _name = name;
        }

        public void Update(int temperature)
        {
            Console.WriteLine($"{_name} received update: Temperature = {temperature}");
        }
    }
}
