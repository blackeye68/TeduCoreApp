using TeduCoreApp.Data.Entities;
using TeduCoreApp.Infrastructure.Interfaces;

namespace TeduCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
    }
}