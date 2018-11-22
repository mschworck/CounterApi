using System;
using CounterApi.Models;

namespace CounterApi.Services
{
    public class CounterServices : ICounterServices
    {
        private readonly Counter _counter;

        public CounterServices()
        {
            _counter = new Counter(0);
        }

        public void IncrementCounter()
        {
            if (_counter!=null)
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
