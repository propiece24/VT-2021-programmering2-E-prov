﻿using System;

namespace Prov_2021
{
    class Program
    {
        static void Main(string[] args)
        {


           // här frågar den vilken karaktär man vill köra. 
         Console.WriteLine("Skriv marksman om du vill ha marksman");
         Console.WriteLine("Skriv fighter om du vill ha Fighter");
         string Karaktärtyp = Console.ReadLine();


          // här väljs marksman och man får välja namn
         if( Karaktärtyp == "marksman")
         {
           Marksman myMarksman = new Marksman();
           Console.WriteLine("Vad ska karaktären heta skriv namn");
           myMarksman.name = Console.ReadLine();
           Console.WriteLine(myMarksman.name);
           Console.ReadLine();
         }


         

        }
    }
}
