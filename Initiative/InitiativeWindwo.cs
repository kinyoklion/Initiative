using System;

using Foundation;
using AppKit;

namespace Initiative
{
   public partial class InitiativeWindwo : NSWindow
   {
      public InitiativeWindwo (IntPtr handle) : base (handle)
      {
      }

      [Export ("initWithCoder:")]
      public InitiativeWindwo (NSCoder coder) : base (coder)
      {
      }

      public override void AwakeFromNib ()
      {
         base.AwakeFromNib ();
      }
   }
}
