using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace UbsTest.CalendarControl.MonthControl
{
    public class MonthControlViewModel
    {
        public MonthControlViewModel(DateTime today, DateTime yearAndMonth)
        {            
            Text = $"{CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(yearAndMonth.Month)}, {yearAndMonth.Year}";

            Days = new ObservableCollection<DayControlViewModel>();

            var day = new DateTime(yearAndMonth.Year, yearAndMonth.Month, 1);
            var dayOfWeek = ((int)day.DayOfWeek == 0) ? 7 : (int)day.DayOfWeek;
            var days = DateTime.DaysInMonth(yearAndMonth.Year, yearAndMonth.Month);

            foreach (var i in Enumerable.Range(1, 7 * 6))
            {
                var viewModel = new DayControlViewModel();

                if (i >= dayOfWeek && day.Month == yearAndMonth.Month)
                {
                    viewModel.Text = day.Day.ToString();
                    viewModel.IsVisible = true;
                    viewModel.IsSelected = day == today;
                    viewModel.IsBold = !(day.DayOfWeek == DayOfWeek.Saturday ||
                        day.DayOfWeek == DayOfWeek.Sunday);
                    viewModel.Model = day;

                    day = day.AddDays(1);
                }

                Days.Add(viewModel);
            }
        }

        public string Text { get; }

        public ObservableCollection<DayControlViewModel> Days { get; }
    }
}
