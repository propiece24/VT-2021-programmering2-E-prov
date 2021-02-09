using System;

namespace Prov_2021
{
    public class Fighter: Character
    {
        
       public int Damage = 10;
       public int speed = 30;
       private Random generator = new Random ();

       public void Powerup (int amount)
       {
           Damage += generator.Next(2,4);
       }

       public void Speedup (int amount)
       {
           speed += generator.Next(2,4);
       }

       public void GumGumStamp (int amount)
       {
           Damage += 15;
       }

    }
}
