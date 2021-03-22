namespace {{cookiecutter.project_name}}.Contracts
{
    public interface ILog
    {
        void Success(string message);
        void Error(string message);
        void Info(string message);
    }
}