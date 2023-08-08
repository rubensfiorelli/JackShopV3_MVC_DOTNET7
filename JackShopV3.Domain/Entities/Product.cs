namespace JackShopV3.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public Product(string title, string description, string imgUrl, decimal price, Guid categoryId) : base()
        {
            Title = title;
            Description = description;
            ImgUrl = imgUrl;
            Price = price;
            Active = true;
            CategoryId = categoryId;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ImgUrl { get; private set; }
        public decimal Price { get; private set; }
        public bool Active { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category? Category { get; set; }

        public void SetActive(bool active) => Active = false;


        public void SetValues(string newTitle, string newDescription, string newImgUrl, decimal newPrice)
        {
            Title = newTitle;
            Description = newDescription;
            ImgUrl = newImgUrl;
            Price = newPrice;

        }

    }
}
