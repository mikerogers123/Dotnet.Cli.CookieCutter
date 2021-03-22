using System;
using {{cookiecutter.project_name}}.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace {{cookiecutter.project_name}}.Cli
{
    public static class DependencyResolver
    {
        public static IServiceProvider Register() =>
            new ServiceCollection()
                .AddScoped<IEntryPoint, EntryPoint>()
                .AddScoped<ILog, Log>()
                .AddScoped<IInputReader, InputReader>()
                .BuildServiceProvider();
    }
}