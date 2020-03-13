using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Models
{
    public class Item
    {
        public string ID { get; set; }
        public string ItemName { get; set; }
        public decimal Cost { get; set; }
    }

    public class ItemCollection
    {
        public ItemCollection()
        {
            ItemCol = new List<Item>();
        }
        public List<Item> ItemCol { get; set; }
        public string ItemName { get; set; }
    }

    public class IndexItem
    {
        public string ItemName { get; set; }
    }
}
