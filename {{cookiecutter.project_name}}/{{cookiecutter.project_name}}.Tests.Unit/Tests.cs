using FluentAssertions;
using NUnit.Framework;

namespace {{cookiecutter.project_name}}.Tests.Unit
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Example()
        {
            const string forename = "bob";
            const string surname = "marley";

            $"{forename} {surname}".Should().Be("bob marley");
        }
    }
}