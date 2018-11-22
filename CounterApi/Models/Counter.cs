using System;
namespace CounterApi.Models
{
    public class Counter
    {
        int CounterValue { get; set; }

        public Counter(int count)

        {
            CounterValue = count;

        }

        public void Increment()
        {
            CounterValue++;
        }

        public int GetCounter ()
        {
            return CounterValue;
        }
    }
}
