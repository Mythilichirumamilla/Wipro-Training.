using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    public interface IWeatherObserver
    {
        void Update(int temperature);
    }
}

