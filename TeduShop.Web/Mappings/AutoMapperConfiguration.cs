using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //the older method that does not support anymore
            /*Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();*/
            /*
             * Mapper.Initialize(cfg => {
                  cfg.CreateMap<Source, Dest>();
                });

                var source = new Source();
                var dest = Mapper.Map<Source, Dest>(source);
             */
            //the new way handle for this
            /*Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
            });*/

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();

                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductTag, ProductTagViewModel>();
            });

            /*Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Tag, TagViewModel>();
            });*/
        }
    }
}