using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopKhanMat.Data.Infastructure;
using ShopKhanMat.Data.Repositories;
using ShopKhanMat.Model.Models;
using System.Linq;

namespace ShopKhanMat.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWord;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactoty();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWord = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(1, list.Count());
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test alias";
            category.Status = true;
            var result = objRepository.Add(category);
            unitOfWord.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ID);
        }
    }
}