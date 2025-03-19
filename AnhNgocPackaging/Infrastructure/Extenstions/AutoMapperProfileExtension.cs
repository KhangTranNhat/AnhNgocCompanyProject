namespace AnhNgocPackaging.Infrastructure.Extenstions
{
    public class AutoMapperProfileExtension : Profile
    {
        public AutoMapperProfileExtension()
        {
            //Comon
            CreateMap<ImageModel, ImageResultDto>();
            CreateMap<ConfigModel, ComponentConfigResultDto>();
            CreateMap<ContactModel, ContactResultDto>();
            CreateMap<SocialMediaModel, SocialMediaResultDto>();
            CreateMap<CompanyContactModel, CompanyContactInformationResultDto>();

            //Banner
            CreateMap<BannerEntity, ContentBannerResultDto>();

            //Policy
            CreateMap<PolicyEntity, ContentPolicyResultDto>();

            //Company
            CreateMap<PolicyEntity, ContentPolicyResultDto>();
            CreateMap<CompanyInfoModel, CompanyInformationResultDto>();

            //Product Category
            CreateMap<ProductCategoryEntity, ProductCategoryResultDto>();

            //Product Category
            CreateMap<ProductEntity, ItemListProductResultDto>();
        }
    }
}
