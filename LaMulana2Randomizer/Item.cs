﻿using LaMulana2RandomizerShared;
using Newtonsoft.Json;

namespace LaMulana2Randomizer
{
    public class Item
    {
        public string name;
        public bool isRequired;

        [JsonIgnore]
        public ItemID Id;
        
        [JsonConstructor]
        public Item(string name, ItemID id, bool isRequired = true)
        {
            this.name = name;
            this.Id = id;
            this.isRequired = isRequired;
        }
    }
}
