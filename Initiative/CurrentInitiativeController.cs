using System;

using Foundation;
using AppKit;

namespace Initiative
{
   public partial class CurrentInitiativeController : NSWindowController
   {
      public CurrentInitiativeController (IntPtr handle) : base (handle)
      {
      }

      [Export ("initWithCoder:")]
      public CurrentInitiativeController (NSCoder coder) : base (coder)
      {
      }

      public CurrentInitiativeController () : base ("CurrentInitiative")
      {
      }

      public override void AwakeFromNib ()
      {
         base.AwakeFromNib ();
      }

      public new CurrentInitiative Window {
         get { return (CurrentInitiative)base.Window; }
      }
   }
}
