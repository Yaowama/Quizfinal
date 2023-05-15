using System;
class Program{
    static void Main(string[] args){
        Console.Write("Enter Vmax: ");
        double Vmax = double.Parse(Console.ReadLine());
        Console.Write("Enter tdrink: ");
        double tdrink = double.Parse(Console.ReadLine());
        Console.Write("Enter tfill: ");
        double tfill = double.Parse(Console.ReadLine());
        Console.Write("Enter tday: ");
            int tb = int.Parse(Console.ReadLine());
        Console.Write("Enter tday: ");
            int tr = int.Parse(Console.ReadLine());
        Console.Write("Enter Vdrink: ");
            int tact = int.Parse(Console.ReadLine());
       
        double V = 0;

            int nDrink = tact / tb;
            int nFill = tact / tr;
            double Vbreak = tdrink * nDrink;
            double Vfill = tfill * nFill;
            double Vtotal = Vbreak + Vfill;
        if (Vtotal <= Vmax) {
            V = Vmax - Vtotal;
            Console.WriteLine("Enough Water,{V} left", V);
        } else {
            Console.WriteLine("Not Enough Water");
        if (Vfill >= Vmax) {
            Console.WriteLine("Overflow Water");
      }
       
        Console.Write("Enter Balance 1: ");
        double b1 = double.Parse(Console.ReadLine());
        Console.Write("Enter Balance 2: ");
        double b2 = double.Parse(Console.ReadLine());
        Console.Write("Enter Balance 3: ");
        double b3 = double.Parse(Console.ReadLine());

        while (true)
        {
            Console.Write("Enter paid amount (0 or negative to stop): ");
            double paid = double.Parse(Console.ReadLine());

            if (paid <= 0)
            {
                break;
            }

            if (paid <= b1)
            {
                b1 -= paid;
            }
            else if (paid <= b1 + b2)
            {
                b2 -= (paid - b1);
                b1 = 0;
            }
            else if (paid <= b1 + b2 + b3)
            {
                b3 -= (paid - b1 - b2);
                b2 = b1 = 0;
            }
            else
            {
                Console.WriteLine("Paid amount is greater than total balance.");
            }
        }

        Console.WriteLine("Balance 1 : {b1}",b1);
        Console.WriteLine("Balance 2 : {b2}",b2);
        Console.WriteLine("Balance 3 : {b3}",b3);

        double l = b1 + b2 + b3;

        if (l > 0)
        {
            Console.WriteLine("Unpaid balance : {l}",l);
     
    }
   }
  }
 }

   