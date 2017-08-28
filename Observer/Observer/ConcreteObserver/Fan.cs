using Observer.Observer;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ConcreteObserver
{
    // Concrete Observer
    public class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified. Tweet of {celebrity.FullName}: {celebrity.Tweet}");
        }
    }
}
