﻿using AppKit;

namespace TheSharpFactory.Apps.Cross.macOS
{
    static class MainClass
    {
        private static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.SharedApplication.Delegate = new AppDelegate();
            NSApplication.Main(args);
        }
    }
}
