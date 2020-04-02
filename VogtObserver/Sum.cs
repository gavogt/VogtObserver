using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class Sum : IObserver
    {
        private RandomNumberGenerator _generator;
        private int _randomInt;

        public Sum(RandomNumberGenerator generator)
        {
            _generator = generator;
        }

        public void Update()
        {
            _randomInt = _generator.GetRandomInt()+_randomInt;
            Console.WriteLine($"Sum: {_randomInt}");
        }
    }
}
