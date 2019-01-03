// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CustomHeader_iOS
{
    [Register ("MyViewCS")]
    partial class MyView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Syncfusion.SfSchedule.iOS.SFSchedule schedule { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (label != null) {
                label.Dispose ();
                label = null;
            }

            if (schedule != null) {
                schedule.Dispose ();
                schedule = null;
            }
        }
    }
}