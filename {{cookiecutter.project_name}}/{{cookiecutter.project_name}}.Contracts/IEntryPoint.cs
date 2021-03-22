using System.Threading.Tasks;

namespace {{cookiecutter.project_name}}.Contracts
{
    public interface IEntryPoint
    {
        Task RunAsync(IOptions options);
    }
}