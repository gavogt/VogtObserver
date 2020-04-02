using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class Sum : IObserver
    {
        private int _randomInt;

        public Sum()
        {

        }

        public void Update(int random)
        {

            Console.WriteLine($"Sum: {random}");
        }
    }
}
