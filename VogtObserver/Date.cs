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

            string formatDate = Convert.ToString(_dateTime.AddDays(_randomInt));

            Console.WriteLine("Dates added: {0:yyyy MM d}", formatDate);
        }
    }
}
