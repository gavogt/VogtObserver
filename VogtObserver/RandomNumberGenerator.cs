﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    class RandomNumberGenerator : IObservable
    {

          private List<IObserver> _observers;

        public void Add(IObserver o)
        {
            _observers.Add(o);
        }

        public void Notify()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(GetRandomInt());
            }
        }

        public void Remove(IObserver o)
        {
            _observers.Remove(o);
        }

        public int GetRandomInt()
        {
            var random = new Random();

            return random.Next(1, 1000);
        }
    }
}
