using System;
using System.Collections.Generic;
using System.Text;

namespace VogtObserver
{
    interface IObservable
    {
        public void Add(IObservable o);
        public void Remove(IObservable o);
        public void Notify();
    }
}
