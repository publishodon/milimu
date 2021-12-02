using Ninject;
using Softozor.Publishodon;

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
            Log.Info("starting application");
            using var kernel = KernelFactory.Create();
            var bootstrapper = kernel.Get<Bootstrapper>();
            var result = await bootstrapper.RunAsync(args);
            return (int) result;
        }
    }
}