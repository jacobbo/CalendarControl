using System;

namespace UbsTest.CalendarControl
{
    public class Event
    {
        public DateTime Start { get; set; }

        public TimeSpan Duration { get; set; }

        public string Description { get; set; }
    }
}
