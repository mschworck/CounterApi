using System;
using CounterApi.Controllers;
using CounterApi.Models;
using CounterApi.Services;

namespace CounterApi.Tests
{
    public class CounterServiceTest : ICounterServices
    {
        Counter _counter;

        public CounterServiceTest()
        {
            _counter = new Counter(0);
        }

        public void IncrementCounter()
        {
            if (_counter != null)
            {
                _counter.Increment();
            }
        }

        public int GetCounter()
        {
            return _counter.GetCounter();
        }

    }
}
