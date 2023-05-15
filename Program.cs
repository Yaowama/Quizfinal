using System;

class Program {
    static void Main(string[] args) {
        Console.Write(" Total Items : ");
        int numItems = int.Parse(Console.ReadLine());
        while (int.TryParse(Console.ReadLine(), out numItems) || numItems < 1) {
        }
         Console.Write("Enter name of Item : ");
            string name = Console.ReadLine();

            Console.Write("Enter type of Item : ");
            string type = Console.ReadLine();

            Console.Write("{Itemp} ", name ,type);
            
    }
        Console.Write("ShowAll : ");
        string itemName = Console.ReadLine();
            if (itemName.ToLower() == "showall")           
} 
            

