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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton AddButton { get; set; }

		[Outlet]
		AppKit.NSTableView InitiativeTable { get; set; }

		[Outlet]
		AppKit.NSTableColumn MentalColumn { get; set; }

		[Outlet]
		AppKit.NSButton NextButton { get; set; }

		[Outlet]
		AppKit.NSTableColumn PhysicalColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn PlayerColumn { get; set; }

		[Outlet]
		AppKit.NSButton RemoveButton { get; set; }

		[Outlet]
		AppKit.NSButton SaveButton { get; set; }

		[Action ("AddAction:")]
		partial void AddAction (Foundation.NSObject sender);

		[Action ("BUttonAction:")]
		partial void BUttonAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AddButton != null) {
				AddButton.Dispose ();
				AddButton = null;
			}

			if (InitiativeTable != null) {
				InitiativeTable.Dispose ();
				InitiativeTable = null;
			}

			if (MentalColumn != null) {
				MentalColumn.Dispose ();
				MentalColumn = null;
			}

			if (NextButton != null) {
				NextButton.Dispose ();
				NextButton = null;
			}

			if (PhysicalColumn != null) {
				PhysicalColumn.Dispose ();
				PhysicalColumn = null;
			}

			if (RemoveButton != null) {
				RemoveButton.Dispose ();
				RemoveButton = null;
			}

			if (PlayerColumn != null) {
				PlayerColumn.Dispose ();
				PlayerColumn = null;
			}

			if (SaveButton != null) {
				SaveButton.Dispose ();
				SaveButton = null;
			}
		}
	}
}
