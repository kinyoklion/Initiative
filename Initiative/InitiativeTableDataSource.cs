using System;
using AppKit;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Initiative
{
   public class InitiativeTableDataSource : NSTableViewDataSource
   {
      private List<PlayerInitiative> playerInitiatives;

      public InitiativeTableDataSource (List<PlayerInitiative> initiatives)
      {
         playerInitiatives = initiatives;
      }

      public PlayerInitiative Get (int index)
      {
         return playerInitiatives [index];
      }

      public void Add (PlayerInitiative newInitiative)
      {
         playerInitiatives.Add (newInitiative);
      }

      public void Remove (int index)
      {
         playerInitiatives.RemoveAt (index);
      }

      public int Count ()
      {
         return playerInitiatives.Count;
      }

      public void Write (string fileName)
      {
         var formatter = new BinaryFormatter ();
         using (var writer = new StreamWriter (fileName)) {
            formatter.Serialize (writer.BaseStream, playerInitiatives);
         }
      }

      public override nint GetRowCount (NSTableView tableView)
      {
         return Count ();
      }
   }
}
