using System;
using System.Collections.Generic;

namespace Observer
{
    public class BaggageObserver : IObserver<BaggageInfo>
    {
        private readonly string _name;
        private readonly List<string> _flightInfos = new List<string>();
        private IDisposable _cancellation;
        private readonly string fmt = "{0,-20} {1,5}  {2, 3}";

        public BaggageObserver(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("The observer must be assigned a name.");

            _name = name;
        }

        public virtual void Subscribe(BaggageProvider provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
            _flightInfos.Clear();
        }

        public virtual void OnCompleted()
        {
            _flightInfos.Clear();
        }

        /* No implementation needed: Method is not called by the BaggageHandler class. */
        public virtual void OnError(Exception e)
        {}

        /* Update information. */
        public virtual void OnNext(BaggageInfo info)
        {
            var updated = false;

            /* Flight has unloaded its baggage; remove from the monitor. */
            if (info.Carousel == 0)
            {
                var flightsToRemove = new List<string>();
                var flightNo = string.Format("{0,5}", info.FlightNumber);

                foreach (var flightInfo in _flightInfos)
                {
                    if (flightInfo.Substring(21, 5).Equals(flightNo))
                    {
                        flightsToRemove.Add(flightInfo);
                        updated = true;
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                {
                    _flightInfos.Remove(flightToRemove);
                }

                flightsToRemove.Clear();
            }
            else
            {
                /* Add flight if it does not exist in the collection. */
                var flightInfo = string.Format(fmt, info.From, info.FlightNumber, info.Carousel);
                if (!_flightInfos.Contains(flightInfo))
                {
                    _flightInfos.Add(flightInfo);
                    updated = true;
                }
            }
            if (updated)
            {
                _flightInfos.Sort();

                Console.WriteLine("Arrivals information from {0}", _name);

                foreach (var flightInfo in _flightInfos)
                {
                    Console.WriteLine(flightInfo);
                }

                Console.WriteLine();
            }
        }
    }
}