
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace Hello_Mac
{
  public partial class MainWindow : MonoMac.AppKit.NSWindow
  {
    private int numberOfTimesClicked = 0;

    #region Constructors

    // Called when created from unmanaged code
    public MainWindow(IntPtr handle) : base(handle)
    {
      Initialize();
    }
    
    // Called when created directly from a XIB file
    [Export("initWithCoder:")]
    public MainWindow(NSCoder coder) : base(coder)
    {
      Initialize();
    }
    
    // Shared initialization code
    void Initialize()
    {
    }

    #endregion

    public override void AwakeFromNib()
    {
      base.AwakeFromNib();

      // Set the initial value for the label
      ClickedLabel.StringValue = "Button has not been clicked yet.";
    }

    partial void ClickedButton(NSObject sender)
    {

      // Update counter and label
      ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
    }
  }
}

