using System;
namespace PensionssimulatorC {
   class Pensionssimulator {
      static void Main(string[] args) {
         Console.WriteLine("Välkomna till denna pensionssimulator \nVad heter du i förnamn?");
         string Name = Console.ReadLine();
         Console.WriteLine("Hur gammal är du?");
         int Age = int.Parse(Console.ReadLine()); 
         int Pension = 65 - Age;
         Console.WriteLine("Hej " + Name + ". Du går i pension om " + Pension + " år.\nPress any key to continue...");
         Console.ReadLine();
      }
   }
}