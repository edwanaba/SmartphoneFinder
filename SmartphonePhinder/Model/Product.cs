
namespace SmartphonePhinder.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = string .Empty;

        public string Description { get; set; } = string.Empty;

        public float Price { get; set; }
        public float DiscountPercentage { get; set; }

        public float Rating { get; set; }

        public int Stock { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;
        
        public string ThumbNail { get; set; } = string.Empty;

        public List<string> Images { get; set; } = new List<string>();

        public override string ToString()
        {
            var productString = $"Title: {Title}{Environment.NewLine}Description: {Description}{Environment.NewLine}Price: {Price}{Environment.NewLine}Discount: {DiscountPercentage}{Environment.NewLine}Rating: {Rating}{Environment.NewLine}";
            return productString;
        }


    }
}
