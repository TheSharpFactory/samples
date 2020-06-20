using System;

namespace TheSharpFactory.Apps.Web.SharedUI
{
    [Flags]
    public enum BlazorPlatform
    {
        Web,
        Electron,
        WebWindow,
        iOS,
        Android,
        UWP,
        Desktop
    }
}
