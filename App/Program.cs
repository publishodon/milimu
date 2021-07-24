using System.Threading.Tasks;
using Ninject;
using Softozor.Publishodon;

namespace App
{
    internal class Program
    {
        private static async Task<int> Main(string[] args)
        {
            using var kernel = KernelFactory.Create();
            var bootstrapper = kernel.Get<Bootstrapper>();
            var result = await bootstrapper.RunAsync(args);
            return (int) result;
        }
    }
}