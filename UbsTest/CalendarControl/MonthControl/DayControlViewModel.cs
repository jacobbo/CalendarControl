using System;

namespace UbsTest.CalendarControl.MonthControl
{
    public class DayControlViewModel : NotifyPropertyChangedBase
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { SetField(ref _text, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetField(ref _description, value); }
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set { SetField(ref _isVisible, value); }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set { SetField(ref _isSelected, value); }
        }

        private bool _isHighlighted;
        public bool IsHighlighted
        {
            get { return _isHighlighted; }
            set { SetField(ref _isHighlighted, value); }
        }

        private bool _isBold;
        public bool IsBold
        {
            get { return _isBold; }
            set { SetField(ref _isBold, value); }
        }

        public DateTime Model { get; set; }
    }
}
