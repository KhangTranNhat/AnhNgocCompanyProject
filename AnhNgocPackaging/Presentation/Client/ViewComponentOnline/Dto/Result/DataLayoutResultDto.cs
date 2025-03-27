
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Dto.Result
{
    public class DataLayoutResultDto : BaseResponseDto
    {
        public ListProductCategoryResultDto ProductCategories = new ListProductCategoryResultDto();
        public CompanyResultDto Company { get; set; } = new CompanyResultDto();
    }
    public class CompanyResultDto : BaseResponseDto
    {
        public CompanyContactResultDto Contact { get; set; } = new CompanyContactResultDto();
        public CompanyGoogleDataResultDto Google { get; set; } = new CompanyGoogleDataResultDto();
        public CompanyInfoResultDto Info { get; set; } = new CompanyInfoResultDto();
    }

    public class CompanyContactResultDto : ContactResultDto
    {
        public string Description { get; set; } = string.Empty;
        public string OpeningHourWorking { get; set; } = string.Empty;
        public SocialMediaResultDto SocialMedia { get; set; } = new SocialMediaResultDto();
    }

    public class CompanyGoogleDataResultDto : BaseResponseDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Keyword { get; set; } = string.Empty;
        public string Map { get; set; } = string.Empty;
        public string Analytics { get; set; } = string.Empty;
        public string SiteVerification { get; set; } = string.Empty;
    }

    public class CompanyInfoResultDto
    {
        public string Name { get; set; } = string.Empty;
        public string PrimaryLogo { get; set; } = string.Empty;
        public string SecondaryLogo { get; set; } = string.Empty;
        public string Favicon { get; set; } = string.Empty;
    }
}
