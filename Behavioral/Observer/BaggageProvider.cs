using System;
using System.Collections.Generic;

namespace Observer
{
    public class BaggageProvider : IObservable<BaggageInfo>
    {
        private readonly List<IObserver<BaggageInfo>> _observers;
        private readonly List<BaggageInfo> _flights;

        public BaggageProvider()
        {
            _observers = new List<IObserver<BaggageInfo>>();
            _flights = new List<BaggageInfo>();
        }

        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);

                foreach (var baggageInfo in _flights)
                    observer.OnNext(baggageInfo);
            }

            return new Unsubscriber<BaggageInfo>(_observers, observer);
        }

        /* Called to indicate all baggage is now unloaded. */
        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo, string.Empty, 0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);

            /* Carousel is assigned, so add new info object to list. */
            if (carousel > 0 && !_flights.Contains(info))
            {
                _flights.Add(info);
                foreach (var observer in _observers)
                {
                    observer.OnNext(info);
                }
            }
            else if (carousel == 0)
            {
                /* Baggage claim for flight is done */
                var flightsToRemove = new List<BaggageInfo>();

                foreach (var flight in _flights)
                {
                    if (info.FlightNumber == flight.FlightNumber)
                    {
                        flightsToRemove.Add(flight);
                        foreach (var observer in _observers)
                        {
                            observer.OnNext(info);
                        }
                    }
                }

                foreach (var flightToRemove in flightsToRemove)
                {
                    _flights.Remove(flightToRemove);
                }

                flightsToRemove.Clear();
            }
        }

        public void LastBaggageClaimed()
        {
            foreach (var observer in _observers)
            {
                observer.OnCompleted();
            }

            _observers.Clear();
        }
    }
}