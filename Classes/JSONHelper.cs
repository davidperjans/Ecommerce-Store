using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Webshop.Classes
{
    public class JSONHelper
    {
        public static List<Product> LoadProductsFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"The file {filePath} does not exist.");

            var jsonData = File.ReadAllText(filePath);

            var productList = JsonConvert.DeserializeObject<ProductList>(jsonData);
            return productList.Products;
        }
    }
}
