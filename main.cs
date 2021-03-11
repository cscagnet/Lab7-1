using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Hours parked?");
    int hours = Convert.Int32(Console.ReadLine());

    Console.WriteLine ("parkings charges = $"  + CalculateCharges());

  
  }
  public static void CalculateCharges()
  {
  if (hours <= 3)
    {
      Console.WriteLine("Charge is $2.00");
    }
  if else (hours >3; hours <24)
    {
      double charges = hours * 0.5;
    }
  else 
    {
      Console.WriteLine("Charge is $10.00");
    }

  }


  }
}