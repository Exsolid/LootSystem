using System;
using System.Collections.Generic;

namespace LootSystem
{
    class Table
    {
        public List<GroupDrop> AllGroups { get; }
        private Random rand;

        public Table()
        {
            AllGroups = new List<GroupDrop>();
            rand = new Random();
        }

        public List<Item> GetLoot()
        {
            List<Item> items = new List<Item>();

            foreach (GroupDrop gDrop in AllGroups)
            {
                if (rand.NextDouble() <= gDrop.DropPercentage)
                {
                    items.AddRange(getItemsOfGroup(gDrop));
                    if (rand.NextDouble() <= gDrop.DropDoublePercentage)
                    {
                        items.AddRange(getItemsOfGroup(gDrop));
                    }
                }
            }

            return items;
        }

        private List<Item> getItemsOfGroup(GroupDrop gDrop)
        {

            List<Item> items = new List<Item>();
            List<Amount> list = gDrop.drop();
            foreach(Amount am in list)
            {
                for(int i = 0; i < am.Count; i++)
                {
                    items.Add(am.Item);
                }
            }
            return items;
        }
    }
}
