using System;
using TestLib;
using Xunit;
namespace TestDemo
{
    public class SimpleTest
    {
        [Fact]
        public void Foo_Should_Return_True()
        {
            Class1 testClass = new Class1();
            Assert.True(testClass.Foo());
        }
    }
}