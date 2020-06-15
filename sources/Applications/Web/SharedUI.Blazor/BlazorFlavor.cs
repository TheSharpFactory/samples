using System;

namespace TheSharpFactory.Apps.Web.SharedUI
{
    [Flags]
    public enum BlazorFlavor
    {
        Server,
        WebAssembly,
        PWA,
        Hybrid,
        Native
    }
}
