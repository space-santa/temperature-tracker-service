using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundApplication1
{
    public interface ITemperatureWriter
    {
        Task Write(string value);
    }
}
