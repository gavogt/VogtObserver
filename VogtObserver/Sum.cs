using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class Sum : IObserver
    {
        public Sum()
        {


        }

        public void Update(int random)
        {

            Console.WriteLine($"Sum: {random}");
        }
    }
}
