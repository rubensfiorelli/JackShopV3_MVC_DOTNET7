namespace JackShopV3.Application.OutputModels
{
    public record ProductDto(Guid Id, string Title, string Description, string ImgUrl, decimal Price, bool Active)
    {
    }
}
