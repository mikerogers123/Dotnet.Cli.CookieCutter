using System.Threading.Tasks;
using CommandLine;
using {{cookiecutter.project_name}}.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace {{cookiecutter.project_name}}.Cli
{
    public class Program
    {
        public static void Main(string[] args) =>
            Parser
                .Default
                .ParseArguments<Options>(args)
                .WithParsed(async options => await RunProgram(options));

        private static Task RunProgram(IOptions o)
        {
            var serviceProvider = DependencyResolver.Register();

            var entryPoint = serviceProvider.GetService<IEntryPoint>();

            return entryPoint.RunAsync(o);
        }
    }
}
