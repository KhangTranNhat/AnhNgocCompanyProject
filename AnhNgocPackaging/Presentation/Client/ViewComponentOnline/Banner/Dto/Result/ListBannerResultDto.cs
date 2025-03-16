namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner.Dto.Result
{
    public class ListBannerResultDto : PagingResponseDto
    {
        public ComponentConfigResultDto? Config { get; set; } = null;
        public IEnumerable<ContentBannerResultDto> Items { get; set; } = Enumerable.Empty<ContentBannerResultDto>();
    }
}
