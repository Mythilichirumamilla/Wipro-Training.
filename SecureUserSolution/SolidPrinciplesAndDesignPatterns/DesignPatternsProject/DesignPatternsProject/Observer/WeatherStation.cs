using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    public class WeatherStation
    {
        private List<IWeatherObserver> observers = new();

        public void Register(IWeatherObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IWeatherObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"WeatherStation: Temperature changed to {temperature}");
            NotifyObservers(temperature);
        }

        private void NotifyObservers(int temperature)
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }
}
