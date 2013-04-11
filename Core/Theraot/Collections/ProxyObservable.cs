using System;
using System.Collections.Generic;

using Theraot.Threading;

namespace Theraot.Collections
{
    [Serializable]
    public sealed class ProxyObservable<T> : IObservable<T>, IObserver<T>, IProxyObservable<T>
    {
        private readonly List<IObserver<T>> _observers;

        public ProxyObservable()
        {
            _observers = new List<IObserver<T>>();
        }

        public void OnCompleted()
        {
            foreach (var item in _observers)
            {
                try
                {
                    item.OnCompleted();
                }
                catch
                {
                    //Pokemon
                }
            }
        }

        public void OnError(Exception error)
        {
            foreach (var item in _observers)
            {
                try
                {
                    item.OnError(error);
                }
                catch
                {
                    //Pokemon
                }
            }
        }

        public void OnNext(T value)
        {
            foreach (var item in _observers)
            {
                try
                {
                    item.OnNext(value);
                }
                catch
                {
                    //Pokemon
                }
            }
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            _observers.Add(observer);
            return Disposable.Create(() => _observers.Remove(observer));
        }
    }
}