using System;

namespace JsonReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JSON DEMO");
            FileReader fileReader = new FileReader();
            var inventories = fileReader.GetInventory();

            foreach (var i in inventories)
            {
                Console.WriteLine("Name : " + i.Name);
                Console.WriteLine("Weight : " + i.Weight + " kg");
                Console.WriteLine("Price : " + i.Price + " Rs ");
                Console.WriteLine("-------");
                Console.ReadKey();


            }
        }
    }
}
