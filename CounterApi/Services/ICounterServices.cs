using System;
namespace CounterApi.Services
{
    public interface ICounterServices
    {
        void IncrementCounter();
        int GetCounter();
    }
}
