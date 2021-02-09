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
       //metod för speed 
       public void Speedup (int amount)
       {
           speed += generator.Next(2,4);
       }
        // metod för att öka sin damage
       public void GumGumStamp (int amount)
       {
           Damage += 15;
       }

    }
}
