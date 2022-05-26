using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    internal class StockMain
    {
        StockModel model = new StockModel();
        List<StockModel> inventoryList = new List<StockModel>();

        public void Convert(string filePath)
        {
            Dictionary<string, List<StockModel>> group = new Dictionary<string, List<StockModel>>();
            using (StreamReader file = new StreamReader(filePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<StockModel>>(json);

                foreach (var details in items)
                {
                    Console.WriteLine("StockName: " + details.stockName + " NumberOfStock: " + details.noOfStock + " StockPrice: " + details.stockPrice);
                }
            }
        }
    }
}
