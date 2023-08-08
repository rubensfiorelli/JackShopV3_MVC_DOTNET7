namespace JackShopV3.Application.InputModels
{
    public class ProductInputModel
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string ImgUrl { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }

    }
}
