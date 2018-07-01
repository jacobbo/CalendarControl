using System;
using UbsTest.CalendarControl;

namespace UbsTest
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            CalendarControlViewModel = new CalendarControlViewModel(DateTime.Today);

            CalendarControlViewModel.AddEvent(new Event
            {
                Start = DateTime.Today.AddMonths(1),
                Duration = TimeSpan.FromDays(2),
                Description = "Holiday 1"
            });

            CalendarControlViewModel.AddEvent(new Event
            {
                Start = DateTime.Today.AddMonths(3),
                Duration = TimeSpan.FromDays(4),
                Description = "Holiday 2"
            });

            CalendarControlViewModel.AddEvent(new Event
            {
                Start = DateTime.Today.AddMonths(6),
                Duration = TimeSpan.FromDays(1),
                Description = "Holiday 3"
            });

            CalendarControlViewModel.AddEvent(new Event
            {
                Start = DateTime.Today.AddMonths(10),
                Duration = TimeSpan.FromDays(2),
                Description = "Holiday 4"
            });
        }

        public CalendarControlViewModel CalendarControlViewModel { get; }
    }
}
