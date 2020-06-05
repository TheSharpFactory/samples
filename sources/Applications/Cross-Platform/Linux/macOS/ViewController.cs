using System;

using AppKit;
using Foundation;

namespace TheSharpFactory.Apps.Cross.macOS
{
    public partial class ViewController
        : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override NSObject RepresentedObject
        {
            get => base.RepresentedObject;
            set => base.RepresentedObject = value;// Update the view, if already loaded.
        }

        //public override void ViewDidLoad()
        //    => base.ViewDidLoad();
    }
}
