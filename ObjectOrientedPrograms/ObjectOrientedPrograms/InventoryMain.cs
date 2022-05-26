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
        List<InventoryModel> inventoryList = new List<InventoryModel>();
        
        public void Convert(string filePath)
        {
            Dictionary<string, List<InventoryModel>> group = new Dictionary<string, List<InventoryModel>>();
            using (StreamReader file = new StreamReader(filePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Dictionary<string, List<InventoryModel>>>(json);
                Console.WriteLine("Enter the Product Name");
                string userInput = Console.ReadLine();
                foreach(var details in items)
                {
                    if(userInput == details.Key)
                    {
                        foreach (var data in details.Value)
                        {
                            Console.WriteLine("Name:" + data.name + ", Price:" + data.price + ", Weight:" + data.weight);
                        }
                    }
                }
            }
        }
    }
}
