using System;
using System.Collections.ObjectModel;
using System.Linq;
using UbsTest.CalendarControl.MonthControl;

namespace UbsTest.CalendarControl
{
    public class CalendarControlViewModel
    {
        public CalendarControlViewModel(DateTime today)
        {
            Months = new ObservableCollection<MonthControlViewModel>();

            var yearAndMonth = today;

            foreach (var i in Enumerable.Range(0, 12))
            {
                Months.Add(new MonthControlViewModel(today, yearAndMonth));
                yearAndMonth = yearAndMonth.AddMonths(1);
            }
        }

        public ObservableCollection<MonthControlViewModel> Months { get; }

        public void AddEvent(Event e)
        {
            foreach (var m in Months)
            {
                foreach (var d in m.Days)
                {
                    if (d.Model != null &&
                        d.Model >= e.Start && d.Model < e.Start.Add(e.Duration))
                    {
                        d.IsHighlighted = true;
                        d.Description = e.Description;
                    }
                }
            }
        }
    }
}
