using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.Background;
using System.Threading.Tasks;
using CronLib;

namespace BackgroundApplication1
{
    public sealed class StartupTask : IBackgroundTask
    {
        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            BackgroundTaskDeferral deferral = taskInstance.GetDeferral();

            Logger.Log.Instance.UseConsole = Config.Instance.Logger == "Console";
            TemperatureRunner.Run();

            deferral.Complete();
        }
    }
}
