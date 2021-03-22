# .NET Core Console Application Template

Leverage [cookiecutter](https://cookiecutter.readthedocs.io/en/1.7.2/overview.html) and use this repository as a template for your next .NET Core console application.

## Aim

As a developer, creating a console application is often the easiest way to perform basic actions. Having a template should remove some bolier-plate code from each of the applications that you write. It should also help to enforce best practices are adhered to.

## Features

- .NET Core 3.1
- Dependency Injection using the built-in [ServiceCollection](https://docs.microsoft.com/en-us/archive/msdn-magazine/2016/june/essential-net-dependency-injection-with-net-core)
- Strongly typed command-line arguments via [CommandLineParser](https://github.com/commandlineparser/commandline)
- Unit testing via [NUnit](https://github.com/nunit/nunit) and [FluentAssertions](https://fluentassertions.com/introduction)

## Usage

- Install cookiecutter - [guidance](https://cookiecutter.readthedocs.io/en/1.7.2/installation.html)
- Open CMD prompt
- Navigate to the directory you want your application to sit in
- Decide on a project name
- Execute `cookiecutter X`, supplying your desired project name when prompted
