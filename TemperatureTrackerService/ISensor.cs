using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureTrackerService
{
    internal interface ISensor
    {
        double Temperature { get; }
    }
}
