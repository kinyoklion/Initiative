using System;

using Foundation;
using AppKit;

namespace Initiative
{
   public partial class CurrentInitiativeWindow : NSWindow
   {
      public CurrentInitiativeWindow (IntPtr handle) : base (handle)
      {
      }

      [Export ("initWithCoder:")]
      public CurrentInitiativeWindow (NSCoder coder) : base (coder)
      {
      }

      public override void AwakeFromNib ()
      {
         base.AwakeFromNib ();
         Level = NSWindowLevel.Floating;
      }

   }
}
