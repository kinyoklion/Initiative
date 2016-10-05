using System;
namespace Initiative
{
   [Serializable]
   public class PlayerInitiative
   {
      public string Name { set; get; }
      public int PhysicalInitiative { set; get; }
      public int MentalInitiative { set; get; }

      public PlayerInitiative ()
      {
         Name = "New Player";
      }

      public PlayerInitiative (string name, int physical, int mental)
      {
         Name = name;
         PhysicalInitiative = physical;
         MentalInitiative = mental;
      }
   }
}
