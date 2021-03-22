using System.Threading.Tasks;
using {{cookiecutter.project_name}}.Contracts;

namespace {{cookiecutter.project_name}}
{
    public class EntryPoint : IEntryPoint
    {
        private readonly ILog _log;

        public EntryPoint(ILog log) => _log = log;

        public Task RunAsync(IOptions options)
        {
            _log.Info("Hello world!");

            return Task.CompletedTask;
        }
    }
}
