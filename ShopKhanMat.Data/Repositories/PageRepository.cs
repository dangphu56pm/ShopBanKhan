using ShopKhanMat.Data.Infastructure;
using ShopKhanMat.Model.Models;

namespace ShopKhanMat.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}