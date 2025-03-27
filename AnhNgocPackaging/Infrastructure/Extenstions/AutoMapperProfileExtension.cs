namespace AnhNgocPackaging.Infrastructure.Extenstions
{
    public class AutoMapperProfileExtension : Profile
    {
        public AutoMapperProfileExtension()
        {
            //Comon Map
            CreateMap<ImageModel, ImageResultDto>();
            CreateMap<ContactModel, ContactResultDto>();
            CreateMap<SocialMediaModel, SocialMediaResultDto>();

            //Banner Map
            CreateMap<BannerEntity, ContentBannerResultDto>();

            //Policy Map
            CreateMap<PolicyEntity, ContentPolicyResultDto>();
            CreateMap<PolicyEntity, ContentPolicyResultDto>();

            //Product Category Map

            CreateMap<ProductCategoryEntity, ItemListProductCategoryResultDto>();

            //Product Map
            CreateMap<ProductEntity, ItemListProductResultDto>();

            //Company Map
            CreateMap<CompanyContactModel, CompanyContactResultDto>();
            CreateMap<CompanyInfoModel, CompanyInfoResultDto>();
            CreateMap<GoogleDataModel, CompanyGoogleDataResultDto>();
            CreateMap<CompanyEntity, CompanyResultDto>();

            //News
            CreateMap<NewsEntity, ItemListNewsResultDto>();


            //Component
            CreateMap<ComponentEntity, ComponentResultDto>();
            CreateMap<ConfigModel, ConfigResultDto>();
            CreateMap<ContentModel, ContentResultDto>();
        }
    }
}
