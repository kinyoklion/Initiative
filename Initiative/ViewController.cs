using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using AppKit;
using Foundation;

namespace Initiative
{
   public partial class ViewController : NSViewController
   {
      private readonly string initiativeFile = Environment.GetFolderPath (Environment.SpecialFolder.Personal) + "/inititatives.dat";

      public ViewController (IntPtr handle) : base (handle)
      {
         
      }

      struct SpecificInitiative
      {
         public enum InitiativeType
         {
            Physical,
            Mental
         }

         public string Name;
         public int Initiative;
         public InitiativeType Type;
      }

      InitiativeTableDataSource dataSource;
      private static bool ran = false;

      public override void AwakeFromNib ()
      {
         base.AwakeFromNib ();
         //Something is causing this to wake multiple times.
         if (!ran) {
            ran = true;
            RunOnce ();
         }
      }

      public override void ViewDidLoad ()
      {
         base.ViewDidLoad ();
      }

      void RunOnce ()
      {
         var initialInitiatives = new List<PlayerInitiative> ();

         try {
            var formatter = new BinaryFormatter ();
            using (var reader = new StreamReader (initiativeFile)) {
               initialInitiatives = (List<PlayerInitiative>)formatter.Deserialize (reader.BaseStream);
            }
         } catch {
            //Dont care.
         }

         dataSource = new InitiativeTableDataSource (initialInitiatives);

         if (dataSource.Count () == 0) {
            dataSource.Add (new PlayerInitiative ("New Player", 0, 0));
         }

         InitiativeTable.DataSource = dataSource;
         InitiativeTable.Delegate = new InitiativeTableDelegate (dataSource);

         AddButton.Activated += (sender, e) => {
            dataSource.Add (new PlayerInitiative ());
            InitiativeTable.ReloadData ();
         };

         var currentInitiative = -1;

         NextButton.Activated += (sender, e) => {
            var complete = new List<SpecificInitiative> ();

            for (var initiativeIndex = 0; initiativeIndex < dataSource.Count (); initiativeIndex++) {
               var initiative = dataSource.Get (initiativeIndex);
               if (initiative.PhysicalInitiative >= 0) {
                  complete.Add (new SpecificInitiative { Name = initiative.Name, Initiative = initiative.PhysicalInitiative, Type = SpecificInitiative.InitiativeType.Physical });
               }
               if (initiative.MentalInitiative >= 0) {
                  complete.Add (new SpecificInitiative { Name = initiative.Name, Initiative = initiative.MentalInitiative, Type = SpecificInitiative.InitiativeType.Mental });
               }
            }

            var sorted = complete.OrderByDescending ((arg) => arg.Initiative).ToList ();
            currentInitiative++;
            if (currentInitiative >= sorted.Count) {
               currentInitiative = 0;
            }
            if (sorted.Count > 0) {
               AppDelegate.Instance.CurrentInitiativeWindow.SetPlayer (sorted [currentInitiative].Name);
               AppDelegate.Instance.CurrentInitiativeWindow.SetType (sorted [currentInitiative].Type.ToString ());
            }
         };

         SaveButton.Activated += (sender, e) => {
            dataSource.Write (initiativeFile);
         };

         RemoveButton.Activated += (sender, e) => {
            if (InitiativeTable.SelectedRowCount != 0) {
               dataSource.Remove ((int)InitiativeTable.SelectedRow);
               InitiativeTable.ReloadData ();
            }
         };
      }

      public override NSObject RepresentedObject {
         get {
            return base.RepresentedObject;
         }
         set {
            base.RepresentedObject = value;
            // Update the view, if already loaded.
         }
      }
   }
}
