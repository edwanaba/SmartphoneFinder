using SmartphonePhinder.Services;

namespace SmartphonePhinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var restClient = new RestSharp.RestClient();
            var productsUrl = @"https://dummyjson.com/products/category/smartphones";
            var productService = new DummyProductService(restClient, productsUrl);

            var products = productService.GetProducts();

            var discountedProducts = products.Where(x => (x.Price - (x.Price * (x.DiscountPercentage/100))) < 500).ToList();
            var bestProduct = discountedProducts.OrderBy(x => x.Rating).Last();

            Console.WriteLine(bestProduct);
        }
    }
}
