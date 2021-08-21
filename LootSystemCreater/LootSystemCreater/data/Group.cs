using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootSystemCreater.data
{
    class Group : Drop
    {
        public List<Drop> drops;
        private string name;
        public string Name { get { return name; } }
        public Group(string name)
        {
            this.name = name;
            drops = new List<Drop>();
        }
    }
}
