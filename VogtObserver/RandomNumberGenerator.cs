using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VogtObserver
{
    class RandomNumberGenerator : IObservable
    {

        private List<IObserver> _observers = new List<IObserver>();
        private Random _random = new Random();

        public void Add(IObserver o)
        {
            _observers.Add(o);
            _random = new Random();
        }

        public void Notify(int number)
        {

            foreach (IObserver o in _observers)
            {

                o.Update(number);
            }


        }

        public void Remove(IObserver o)
        {
            _observers.Remove(o);
        }

        public int ChangeToRandomNumber()
        {
            int number = 0;
            try
            {
                number = _random.Next(1, 1000);
                Notify(number);

            }
            catch
            {
                Console.WriteLine("Recursion issue!");
            }

            return number;
        }
    }
}
