using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    interface IObservable
    {
        public void Add(IObserver o);
        public void Remove(IObserver o);
        public void Notify(int number);
    }
}
