using System;

namespace ShopKhanMat.Data.Infastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopKhanMatContext Init();
    }
}