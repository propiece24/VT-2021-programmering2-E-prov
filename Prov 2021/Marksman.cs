using System;

namespace Prov_2021
{
    public class Marksman: Character
    {
        
       public int Damage = 5;
       public int speed = 50;
       private Random generator = new Random ();

       public void Powerup (int amount)
       {
           Damage += generator.Next(1,2);
       }

       public void Speedup (int amount)
       {
           speed += generator.Next(4,6);
       }

       public void Firebirdstar (int amount)
       {
           Damage += 10;
       }




    }
}
