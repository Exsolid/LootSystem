using System;
using System.Collections.Generic;
using System.Text;

namespace LootSystem
{
    class Amount
    {
        public Item Item { get; }
        public int Count { get; }
        
        public Amount(Item item, int count)
        {
            Item = item;
            Count = count;
        }
    }
}
