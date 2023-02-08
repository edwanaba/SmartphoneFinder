using SmartphonePhinder.Model;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SmartphonePhinder.Services
{
    public class DummyProductService : IDummyProductService
    {
        private readonly RestClient _dummyClient;
        private readonly string _productsUrl;

        public DummyProductService(RestClient httpClient, string productsUrl)
        {
            _productsUrl = productsUrl;
            _dummyClient = httpClient;

        }
        public List<Product> GetProducts()
        {
            try
            {
                var products = new List<Product>();

                var productRequest = new RestRequest(_productsUrl);
                var productsResponse = _dummyClient.Get(productRequest);
                var producstJObject = JObject.Parse(productsResponse.Content).First;

                foreach (var productJson in producstJObject.Values())
                {
                    var product = JsonConvert.DeserializeObject<Product>(productJson.ToString());
                    products.Add(product);
                }

                return products;
                
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

    }
}
