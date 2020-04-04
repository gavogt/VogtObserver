using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class Date : IObserver
    {
        private DateTime _dateTime = DateTime.Now;
        private readonly RandomNumberGenerator _randomNumberGenerator;

        public Date(RandomNumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _randomNumberGenerator.Add(this);
        }

        public void Update(int random)
        {

            string formatDate = Convert.ToString(_dateTime.AddDays(random));

            Console.WriteLine("Dates added: {0:yyyy MM d}", formatDate);
        }
    }
}
