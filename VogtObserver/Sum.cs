using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class Sum : IObserver
    {
        private Generator _generator;
        private int _randomInt;

        public Sum(Generator generator)
        {
            _generator = generator;
        }

        public void Update()
        {
            _randomInt = _generator.GetRandomInt()+_randomInt;
        }
    }
}
