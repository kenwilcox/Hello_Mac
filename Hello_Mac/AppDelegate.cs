﻿using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace Hello_Mac
{
  public partial class AppDelegate : NSApplicationDelegate
  {
    MainWindowController mainWindowController;

    public AppDelegate()
    {
    }

    public override void DidFinishLaunching(NSNotification notification)
    {
      mainWindowController = new MainWindowController();
      mainWindowController.Window.MakeKeyAndOrderFront(this);
    }

    public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
    {
      return true;
    }
  }
}

