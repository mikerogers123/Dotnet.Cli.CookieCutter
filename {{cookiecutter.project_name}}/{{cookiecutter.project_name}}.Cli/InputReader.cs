using System;
using {{cookiecutter.project_name}}.Contracts;

namespace {{cookiecutter.project_name}}.Cli
{
    public class InputReader : IInputReader
    {
        public string Read() => Console.ReadLine();
    }
}