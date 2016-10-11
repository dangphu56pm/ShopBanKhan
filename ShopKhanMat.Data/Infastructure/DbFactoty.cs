namespace ShopKhanMat.Data.Infastructure
{
    public class DbFactoty : Disposable, IDbFactory
    {
        private ShopKhanMatContext dbContext;

        public ShopKhanMatContext Init()
        {
            return dbContext ?? (dbContext = new ShopKhanMatContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}