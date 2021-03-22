using System;
using {{cookiecutter.project_name}}.Contracts;

namespace {{cookiecutter.project_name}}.Cli
{
    public class Log : ILog
    {
        public void Success(string message) => Console.WriteLine(message, ConsoleColor.Green);

        public void Error(string message) => Console.WriteLine(message, ConsoleColor.Red);

        public void Info(string message) => Console.WriteLine(message);
    }
}