using AppKit;
using Foundation;

namespace Initiative
{
   [Register ("AppDelegate")]
   public class AppDelegate : NSApplicationDelegate
   {
      public AppDelegate ()
      {
      }

      public static AppDelegate Instance { private set; get;}

      public CurrentInitiativeWindowController CurrentInitiativeWindow { private set; get; }

      public override void DidFinishLaunching (NSNotification notification)
      {
         CurrentInitiativeWindow = new CurrentInitiativeWindowController ();
         CurrentInitiativeWindow.Window.MakeKeyAndOrderFront (this);
         Instance = this;
         // Insert code here to initialize your application
      }

      public override void WillTerminate (NSNotification notification)
      {
         // Insert code here to tear down your application
      }
   }
}
