using System;
using UIKit;
using Xamarin.Forms;
using XamarinFloatingTabs.Framework;
using XamarinFloatingTabs.iOS.Framework;

[assembly: Dependency(typeof(DeviceInfo))]
namespace XamarinFloatingTabs.iOS.Framework
{
    public class DeviceInfo : IDeviceInfo
    {
        public float StatusbarHeight => (float)UIApplication.SharedApplication.StatusBarFrame.Size.Height;
    }
}