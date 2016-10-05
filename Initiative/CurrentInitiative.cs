using System;

using Foundation;
using AppKit;

namespace Initiative
{
   public partial class CurrentInitiative : NSWindow
   {
      public CurrentInitiative (IntPtr handle) : base (handle)
      {
      }

      [Export ("initWithCoder:")]
      public CurrentInitiative (NSCoder coder) : base (coder)
      {
      }

      public override void AwakeFromNib ()
      {
         base.AwakeFromNib ();
      }
   }
}
