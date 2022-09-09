using Microsoft.EntityFrameworkCore;
using TesteEntity.Domain;
using TesteEntity.Domain.DTOs.InterfacesRepositories;
using TesteEntity.Repository.Context;

namespace TesteEntity.Repository.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly AppDbContext _context;
        public ProductsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductsEntity>> GetProductsAsync()
        {
            using var context = _context;
            return await context.Products.ToListAsync();
        }
    }
}
