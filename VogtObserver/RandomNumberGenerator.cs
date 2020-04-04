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

        public void Notify()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (IObserver o in _observers)
                {
                    
                    o.Update(GetRandomInt());
                }
            }

        }

        public void NumberChanged()
        {
            Notify();
        }

        public void Remove(IObserver o)
        {
            _observers.Remove(o);
        }

        public int GetRandomInt()
        {

            NumberChanged();
            return _random.Next(1, 1000);

        }
    }
}
