﻿using ShopKhanMat.Data.Infastructure;
using ShopKhanMat.Model.Models;

namespace ShopKhanMat.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}