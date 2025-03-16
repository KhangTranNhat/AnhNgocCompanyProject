
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner.Dto.Result
{
    public class BannerResultDto : BaseResponseDto
    {
        public ComponentConfigResultDto? Config { get; set; } = null;
        public ContentBannerResultDto Content { get; set; } = new ContentBannerResultDto();
    }
   
    public class ContentBannerResultDto
    {
        public string Id { get; set; } = string.Empty;
        public string PrimaryTitle { get; set; } = string.Empty;
        public string SecondaryTitle { get; set; } = string.Empty;
        public string Button { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public ImageResultDto Image { get; set; } = new ImageResultDto();
        public bool IsGrid { get; set; }
    }

}
