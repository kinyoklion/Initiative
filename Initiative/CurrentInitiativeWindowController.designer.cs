// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Initiative
{
	[Register ("CurrentInitiativeWindowController")]
	partial class CurrentInitiativeWindowController
	{
		[Outlet]
		AppKit.NSTextField InitiativeTypeLabel { get; set; }

		[Outlet]
		AppKit.NSTextField PlayerLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (InitiativeTypeLabel != null) {
				InitiativeTypeLabel.Dispose ();
				InitiativeTypeLabel = null;
			}

			if (PlayerLabel != null) {
				PlayerLabel.Dispose ();
				PlayerLabel = null;
			}
		}
	}
}
