using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] options = input.Split();

                Box box = new Box();
                box.SerialNumber = options[0];
                box.Item = new Item();
                box.Item.Name = options[1];
                box.ItemQty = int.Parse(options[2]);
                box.Item.Price = double.Parse(options[3]);
                box.BoxPrice = int.Parse(options[2]) * 1.0 * double.Parse(options[3]);

                boxes.Add(box);
            }

            foreach (var box in boxes.OrderByDescending(x=>x.BoxPrice))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQty}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQty { get; set; }
        public double BoxPrice { get; set; }
    }
}
