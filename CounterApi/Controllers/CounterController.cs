using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CounterApi.Models;
using CounterApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CounterApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly ICounterServices _services;

        public CounterController(ICounterServices services)
        {
            _services = services;
        }


        [HttpGet]
        [Route("GetCounter")]
        public ActionResult<int> GetCounter()
        {
            return _services.GetCounter();
        }

        [HttpGet]
        [Route("Increment")]
        public ActionResult IncrementCounter()
        {
            _services.IncrementCounter();
            return Content("Counter has been incremented (+1)");
        }

        
    }
}