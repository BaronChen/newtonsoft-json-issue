using System.Collections.Generic;

namespace ConsoleApp1.classes
{  
    public class ObjectWithArray
    {
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public string Text { get; set; }
    }
}