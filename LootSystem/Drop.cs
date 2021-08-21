using System;
using System.Collections.Generic;
using System.Text;

namespace LootSystem
{
    abstract class Drop
    {
        public float DropPercentage
        {
            get { return dropPercentage; }
            set
            {
                dropPercentage = Math.Clamp(value, 0f, 1f);
            }
        }

        private float dropPercentage;
    }
}
