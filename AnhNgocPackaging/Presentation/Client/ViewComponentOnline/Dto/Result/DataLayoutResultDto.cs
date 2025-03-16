
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Dto.Result
{
    public class DataLayoutResultDto : BaseResponseDto
    {
        public IEnumerable<ProductCategoryResultDto> ProductCategories = Enumerable.Empty<ProductCategoryResultDto>();
        public CompanyContactInformationResultDto CompanyContact = new CompanyContactInformationResultDto();
        public CompanyInformationResultDto CompanyInfo = new CompanyInformationResultDto();
        public SocialMediaResultDto CompanySocialMedia = new SocialMediaResultDto();
    }
    public class ProductCategoryResultDto
    {
        public string Id { get; set; } = string.Empty;
        public string? Parent_id { get; set; } = null;
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Priority { get; set; }
        public int? TotalProduct { get; set; } = 0;
    }

    public class CompanyContactInformationResultDto : ContactResultDto
    {
        public string Description { get; set; } = string.Empty;
    }

    public class CompanyInformationResultDto
    {
        public string Name { get; set; } = string.Empty;
        public string PrimaryLogo { get; set; } = string.Empty;
        public string SecondaryLogo { get; set; } = string.Empty;
        public string Favicon { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
