using System;
using Foundation;
using ObjCRuntime;
using Syncfusion.SfSchedule.iOS;
using UIKit;

namespace CustomHeader_iOS
{
    public partial class MyView : UIView
    {
        static MyView view;
        public MyView (IntPtr handle) : base (handle)
        {
        }

        public static MyView Create()
        {
            var arguments = NSBundle.MainBundle.LoadNib("MyView", null, null);
            view = Runtime.GetNSObject<MyView>(arguments.ValueAt(0));

            view.schedule.HeaderHeight = 0;

            view.schedule.VisibleDatesChanged += Schedule_VisibleDatesChanged;

            view.label.BackgroundColor = UIColor.Blue;

            return view;
        }

        static void Schedule_VisibleDatesChanged(object sender, Syncfusion.SfSchedule.iOS.VisibleDatesChangedEventArgs e)
        {
            var dateList = e.VisibleDates;

            NSDateFormatter formatter = new NSDateFormatter();
            formatter.DateFormat = "LLLL YYYY";
            formatter.Locale = view.schedule.Locale;

            if (view.schedule.ScheduleView == SFScheduleView.SFScheduleViewMonth)
                view.label.Text = (NSString)formatter.ToString(dateList.GetItem<NSDate>(dateList.Count / 2));
            else
                view.label.Text = (NSString)formatter.ToString(dateList.GetItem<NSDate>(0));
        }
    }
}