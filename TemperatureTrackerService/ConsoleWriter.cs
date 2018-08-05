using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace TemperatureTrackerService
{
    internal class ConsoleWriter : ITemperatureWriter
    {
        public async Task Write(string value)
        {
            Log.Instance.Write(value);
        }
    }
}
