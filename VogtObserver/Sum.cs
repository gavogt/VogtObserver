using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class Sum : IObserver
    {
        private readonly RandomNumberGenerator _randomNumberGenerator;
        public Sum(RandomNumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _randomNumberGenerator.Add(this);
        }

        public void Update(int random)
        {

            Console.WriteLine($"Sum: {random}");
        }
    }
}
