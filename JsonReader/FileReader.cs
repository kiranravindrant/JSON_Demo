using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonReader
{
    public class FileReader
    {
        public List<Inventory> inventories = new List<Inventory>();
        
        public List<Inventory> GetInventory()
        {
            string text = File.ReadAllText("D:\\New folder\\Data.json");
            inventories = JsonConvert.DeserializeObject<List<Inventory>>(text);
            return inventories;
        }

    }
}
