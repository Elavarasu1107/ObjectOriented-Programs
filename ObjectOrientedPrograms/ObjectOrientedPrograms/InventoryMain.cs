using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    internal class InventoryMain
    {
        InventoryModel model = new InventoryModel();
        List<InventoryModel> inventoryList = new List<InventoryModel> ();

        public void Convert(string filePath)
        {
            using (StreamReader file = new StreamReader(filePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryModel>>(json);

                foreach(var details in items)
                {
                    Console.WriteLine("Name: "+details.name+" Price: "+ details.price+" Weight: "+ details.weight);
                }
            }
        }
    }
}
