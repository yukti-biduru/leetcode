using Newtonsoft.Json;
using System.Net;

namespace Leetcode.Solutions
{
    internal class DiscountedPriceOracle
    {
        public int getDiscountedPrice(int barcode)
        {

            string url = "https://jsonmock.hackerrank.com/api/inventory?barcode=" + barcode;
            WebRequest request = WebRequest.Create(url);
            string jsonResponse;
            // Get the response from the API
            using (WebResponse response = request.GetResponse())
            {
                // Get the response stream
                using (Stream dataStream = response.GetResponseStream())
                {
                    // Read the response stream
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        // Read the content of the response
                        jsonResponse = reader.ReadToEnd();

                        // Print the JSON response
                        Console.WriteLine(jsonResponse);
                    }
                }
            }
            dynamic data = JsonConvert.DeserializeObject(jsonResponse);
            int result = 0;
            if (data?.data.Count == 0)
            {
                return -1;
            }
            else
            {
                float discount = data.data[0].discount;
                float price = data.data[0].price;
                Console.WriteLine(price);
                Console.WriteLine(discount);
                float discountedPrice = price - ((discount / 100) * price);
                Console.WriteLine(discountedPrice);
                result = (int)Math.Round(discountedPrice);
                Console.WriteLine(result);
            }

            return result;
        }
    }
}
