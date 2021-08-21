using System;
using System.Linq;
using System.Collections.Generic;

namespace LootSystemCreater.data
{
    class Item : Drop
    {
        private Dictionary<string, Value> args;

        public Item()
        {
            args = new Dictionary<string, Value>();
        }

        public void setValue(Object value, string vauleName)
        {
            args.Add(vauleName, new Value(value));
        }

        public void setValue(string type, string vauleName)
        {
            args.Add(vauleName, new Value(type));
        }

        public void changeValue<T>(string vauleName, Object value)
        {
            T casted = (T)Convert.ChangeType(value, typeof(T));
            args[vauleName].value = casted;
        }

        public string getValueAsString(int index)
        {
            if (args.ElementAt(index).Value.value != null)
                return args.ElementAt(index).Value.value.ToString();
            else return "";
        }

        private class Value
        {
            public Object value;
            private string type;

            public Value(Object value)
            {
                type = value.GetType().Name;
                this.value = value;
            }

            public Value(string type)
            {
                this.type = type;
            }
        }
    }
}
