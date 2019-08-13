using System;
using WebAPI;
using WebAPI.Controllers;
using Xunit;

namespace WebAPITests
{
    public class UnitTest1
    {
        private ValuesController controller = new ValuesController();

        [Fact]
        public void TestForInputHi()
        {
            Assert.Equal("Hello", controller.Get("hi"));
        }

        [Fact]
        public void TestForInputHello()
        {
            Assert.Equal("Hi", controller.Get("hello"));
        }

        [Fact]
        public void TestForInvalidInput()
        {
            Assert.Equal("Invalid Input", controller.Get("hi ABC"));
        }
    }
}
