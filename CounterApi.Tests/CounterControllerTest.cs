using System;
using CounterApi.Controllers;
using CounterApi.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CounterApi.Tests
{
    public class CounterControllerTest
    {
        ICounterServices _service;

        public CounterControllerTest()
        {
            _service = new CounterServiceTest();
        }

        [Fact(DisplayName = "GetCounter should return init value 0")]
        public void GetCounter_should_return_init_value()
        {
            //Arrange
            var controller = new CounterController(_service);

            //Act
            var res = controller.GetCounter();

            //Assert
            Assert.True(res.Value == 0);

        }

        [Fact(DisplayName = "Counter incremented and should return value 1")]
        public void Counter_incremented_and_should_return_value()
        {
            //Arrange
            var controller = new CounterController(_service);

            //Act
            controller.IncrementCounter();
            var res = controller.GetCounter();

            //Assert
            Assert.True(res.Value == 1);

        }
    }
}
