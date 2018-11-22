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

        public CounterControllerTest(ICounterServices counterServices)
        {
            _service = counterServices;
            GetCounter_should_return_init_value();
        }

        [Fact(DisplayName = "Index should return default view")]
        public void GetCounter_should_return_init_value()
        {
            var controller = new CounterController(_service);
            var res = controller.GetCounter();
            Assert.True(res.Value == 0);

        }
    }
}
