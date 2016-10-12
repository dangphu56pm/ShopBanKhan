using AutoMapper;
using ShopKhanMat.Model.Models;
using ShopKhanMat.Web.Models;

namespace ShopKhanMat.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}