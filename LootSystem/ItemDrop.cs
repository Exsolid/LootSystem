using System;
using System.Collections.Generic;
using System.Text;

namespace LootSystem
{
    class ItemDrop : Drop
    {
        public WeightedPicker<int> AmountPicker { get; }
        public Item ItemToDrop { get; }

        public ItemDrop(Item item)
        {
            DropPercentage = 1;
            ItemToDrop = item;
            AmountPicker = new WeightedPicker<int>();
        }

        public int drop()
        {
            if (AmountPicker.isEmpty()) return 1;
            else
            {
                return AmountPicker.PickRandom();
            }
        }
    }
}
