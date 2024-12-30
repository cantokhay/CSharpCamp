using BootcampDapper.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampDapper.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDTO>> GetAllProductsAsync();
        Task CreateProductAsync(CreateProductDTO createProductDTO);
        Task UpdateProductAsync(UpdateProductDTO updateProductDTO);
        Task DeleteProductAsync(int productId);
        Task GetByProduductIdAsync(int productId);
    }
}
