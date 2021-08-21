using System;
using System.Collections.Generic;

namespace LootSystem
{
    class GroupDrop : Drop
    {
        public float DropDoublePercentage
        {
            get { return dropDoublePercentage; }
            set
            {
                dropDoublePercentage = Math.Clamp(value, 0f, 1f);
            }
        }

        private float dropDoublePercentage;

        public List<Drop> Items { get; }
        private Random rand;

        public GroupDrop()
        {
            DropPercentage = 1;
            Items = new List<Drop>();
            rand = new Random();
        }

        public List<Amount> drop()
        {
            List<Amount> allDrops = new List<Amount>();
            foreach (Drop drop in Items)
            {
                if (typeof(ItemDrop).IsInstanceOfType(drop))
                {
                    ItemDrop iDrop = (ItemDrop)drop;
                    if (rand.NextDouble() <= iDrop.DropPercentage)
                    {
                        Amount temp = new Amount(iDrop.ItemToDrop, iDrop.drop());
                        allDrops.Add(temp);
                    }
                }
                else
                {
                    GroupDrop gDrop = (GroupDrop)drop;
                    if (rand.NextDouble() <= gDrop.DropPercentage)
                    {
                        List<Amount> allGroupedDrops = gDrop.drop();
                        allDrops.AddRange(allGroupedDrops);

                        if(rand.NextDouble() <= gDrop.dropDoublePercentage)
                        {
                            allGroupedDrops = gDrop.drop();
                            allDrops.AddRange(allGroupedDrops);
                        }
                    }
                }
            }

            return allDrops;
        }
    }
}
