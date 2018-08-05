using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundApplication1
{
    internal sealed class Config
    {
        private static readonly Config instance = new Config();

        public string Device { get; }
        public string Writer { get; }
        public string EndPoint { get; }
        public string CronJob { get; }
        public string Logger { get; }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Config()
        {
        }

        private Config()
        {
            Device = "SenseHat"; // SenseHat, Mock, BME280
            Writer = "Post"; // Post, Console
            EndPoint = "http://whiterun:4567/api/temperature";
            CronJob = "0 * * * * ?";
            Logger = "File"; // Console, File
        }

        public static Config Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
