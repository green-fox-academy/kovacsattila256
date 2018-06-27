using Counter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Services
{
    public class CounterService : ICounter
    {
        private Number storedValue;

        public CounterService()
        {
            storedValue = new Number() { MyNumber = 0 };
        }

        public Number GetNumber()
        {
            return storedValue;
        }

        public void Increase()
        {
            storedValue.MyNumber++;
        }
    }
}
