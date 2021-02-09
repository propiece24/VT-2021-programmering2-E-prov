using System;

namespace Prov_2021
{
    public class Character
    {
        
      public int hp = 100;
      public string name;
      private Random generator = new Random ();

      public void Hurt (int amount)
      {
          hp -= amount;
      }

      public void Regen (int amount)
      {
          hp += generator.Next(5,15);
      }

      



    }
}
