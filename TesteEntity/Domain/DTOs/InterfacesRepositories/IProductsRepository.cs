namespace TesteEntity.Domain.DTOs.InterfacesRepositories
{
    public interface IProductsRepository
    {
        Task<List<ProductsEntity>> GetProductsAsync();
    }
}
