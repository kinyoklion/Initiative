using System;

using Foundation;
using AppKit;

namespace Initiative
{
   public partial class CurrentInitiativeWindowController : NSWindowController
   {
      public CurrentInitiativeWindowController (IntPtr handle) : base (handle)
      {
      }

      [Export ("initWithCoder:")]
      public CurrentInitiativeWindowController (NSCoder coder) : base (coder)
      {
      }

      public CurrentInitiativeWindowController () : base ("CurrentInitiativeWindow")
      {
      }

      public override void AwakeFromNib ()
      {
         base.AwakeFromNib ();
      }

      public void SetPlayer (string player)
      {
         PlayerLabel.StringValue = player;
      }

      public void SetType (string type)
      {
         InitiativeTypeLabel.StringValue = type;
      }

      public new CurrentInitiativeWindow Window {
         get { return (CurrentInitiativeWindow)base.Window; }
      }
   }
}
