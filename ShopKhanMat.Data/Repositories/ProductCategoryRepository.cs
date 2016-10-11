using ShopKhanMat.Data.Infastructure;
using ShopKhanMat.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopKhanMat.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    internal class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategorys.Where(x => x.Alias == alias);
        }
    }
}