using System;
using LootSystem;
namespace LootSystem
{
    class Sample
    {
        static void Main(string[] args)
        {
            Item stein = new Item("Stein");
            Item stein2 = new Item("Stein-Krass");
            Item stein3 = new Item("Stein-Echt-Krass");
            Item bieber = new Item("Ein Bieber");

            ItemDrop steinD = new ItemDrop(stein);
            steinD.AmountPicker.Add(1, 25);
            steinD.AmountPicker.Add(3, 75);
            ItemDrop stein2D = new ItemDrop(stein2);
            stein2D.DropPercentage = 0.5f;
            ItemDrop stein3D = new ItemDrop(stein3);
            stein3D.DropPercentage = 0.3f;
            ItemDrop bieberD = new ItemDrop(bieber);

            GroupDrop steineD = new GroupDrop();
            steineD.Items.Add(steinD);
            steineD.Items.Add(stein2D);
            steineD.Items.Add(stein3D);
            steineD.DropPercentage = 1f;
            steineD.DropDoublePercentage = 0.5f;

            GroupDrop bieberGD = new GroupDrop();
            bieberGD.Items.Add(bieberD);
            bieberGD.Items.Add(steineD);
            bieberGD.DropPercentage = 0.5f;

            Table lootTable = new Table();
            lootTable.AllGroups.Add(steineD);
            lootTable.AllGroups.Add(bieberGD);

            while (true)
            {
                Console.Clear();
                foreach (Item item in lootTable.GetLoot())
                {
                    Console.WriteLine(item.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
