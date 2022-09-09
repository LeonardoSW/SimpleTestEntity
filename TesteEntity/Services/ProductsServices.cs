using TesteEntity.Domain;
using TesteEntity.Domain.DTOs.InterfacesRepositories;
using TesteEntity.Domain.DTOs.InterfacesRepositories.InterfacesServices;

namespace TesteEntity.Services
{
    public class ProductsServices : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        public ProductsServices(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async Task<List<ProductsEntity>> GetProductsAsync()
        {
            var teste = await _productsRepository.GetProductsAsync();
            return teste;
        }
    }
}
