namespace TesteEntity.Domain.DTOs.InterfacesRepositories.InterfacesServices
{
    public interface IProductsService
    {
        Task<List<ProductsEntity>> GetProductsAsync();
    }
}
