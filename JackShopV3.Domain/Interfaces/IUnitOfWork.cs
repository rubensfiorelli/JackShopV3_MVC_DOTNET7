namespace JackShopV3.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task Rollback();

    }
}
