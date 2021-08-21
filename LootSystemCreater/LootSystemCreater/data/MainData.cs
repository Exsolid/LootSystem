using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootSystemCreater.data
{
    class MainData
    {
        private Dictionary<string, string> itemArgs;
        private List<Item> items;

        public List<Group> Groups;
        
        public MainData()
        {
            Groups = new List<Group>();

            items = new List<Item>();
            itemArgs = new Dictionary<string, string>();
        }

        public void newItem(Dictionary<string, object> args)
        {
            Item item = new Item();
            foreach (string varName in args.Keys)
            {
                if(itemArgs.ContainsKey(varName) && itemArgs[varName].Equals(args[varName].GetType()))
                {
                    item.setValue(args[varName], varName);
                }
            }
            items.Add(item);
        }

        public void newItem()
        {
            Item item = new Item();
            foreach (string varName in itemArgs.Keys)
            {
                item.setValue(itemArgs[varName], varName);
            }
            items.Add(item);
        }

        public void addItemArg(string varName, string varTypeName)
        {
            if (itemArgs.ContainsKey(varName)) throw new Exception("Variable already exists!");
            else itemArgs.Add(varName, varTypeName);
            foreach (Item item in items)
            {
                item.setValue(varTypeName, varName);
            }
        }

        public Item getItem(int index)
        {
            return items[index];
        }
    }
}
