using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class Date : IObserver
    {
        private Generator _generator;
        private DateTime _dateTime = DateTime.Now;
        private int _randomInt;

        public Date(Generator generator)
        {
            _generator = generator;
        }

        public void Update()
        {
            _randomInt = _generator.GetRandomInt();
            Console.WriteLine($"Dates added: {_dateTime.AddDays(_randomInt)}");
        }
    }
}
