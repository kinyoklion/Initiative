using System;
using AppKit;


namespace Initiative
{
   public class InitiativeTableDelegate : NSTableViewDelegate
   {
      private const string CellIdentifier = "InitiativeCell";

      private InitiativeTableDataSource DataSource;

      public InitiativeTableDelegate (InitiativeTableDataSource dataSource)
      {
         this.DataSource = dataSource;
      }

      public override NSView GetViewForItem (NSTableView tableView, NSTableColumn tableColumn, nint row)
      {
         var view = (NSTextField)tableView.MakeView (CellIdentifier, this);
         if (view == null) 
         {
            view = new NSTextField ();
            view.Identifier = tableColumn.Title;
            view.BackgroundColor = NSColor.Clear;
            view.Bordered = false;
            view.Selectable = false;
            view.Editable = true;
         }

         var initiative = DataSource.Get ((int)row);

         view.EditingEnded += (sender, e) => 
         {
            switch (view.Identifier) 
            {
               case "Player":
                  initiative.Name = view.StringValue;
                  break;
               case "Mental":
                  int mental;
                  int.TryParse (view.StringValue, out mental);
                  initiative.MentalInitiative = mental;
                  break;
               case "Physical":
                  int physical;
                  int.TryParse (view.StringValue, out physical);
               initiative.PhysicalInitiative = physical;
                  break;
            }          
         };

         view.Tag = row;

         switch (tableColumn.Title)
         {
            case "Player":
               view.StringValue = initiative.Name;
               break;
            case "Mental":
               view.StringValue = initiative.MentalInitiative.ToString ();
               break;
            case "Physical":
               view.StringValue = initiative.PhysicalInitiative.ToString ();
               break;
         }
         return view;
      }
   }
}
