using ShopKhanMat.Data.Infastructure;
using ShopKhanMat.Model.Models;

namespace ShopKhanMat.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}