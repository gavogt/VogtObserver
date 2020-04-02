using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class Date : IObserver
    {
        private DateTime _dateTime = DateTime.Now;
        private int _randomInt;

        public Date()
        {
            
        }

        public void Update(int random)
        {
            _randomInt = random;

            string formatDate = Convert.ToString(_dateTime.AddDays(_randomInt));

            Console.WriteLine("Dates added: {0:yyyy MM d}", formatDate);
        }
    }
}
