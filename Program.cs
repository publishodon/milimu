namespace App
{
    using System.Threading.Tasks;
    using Properties;
    using log4net;
    using Softozor.Publishodon.Logging;
    
    internal class Program
    {
        private static readonly ILog Log = LoggingSetup.CreateLog(Resources.log4net, typeof(Program), nameof(Program));

        private static async Task<int> Main(string[] args)
        {
            Log.Info("Starting application...");
            return await Softozor.Publishodon.App.Run(args);
        }
    }
}