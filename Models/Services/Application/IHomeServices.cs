using System.Collections.Generic;
using System.Threading.Tasks;
using RCommerce.Models.ViewModels;

namespace RCommerce.Models.Services.Application
{
    public interface IHomeServices
    {
        Task<List<ProductViewModel>> getProductsAsync();
        Task<ProductViewModel> getProductAsync(int id);
    }
}