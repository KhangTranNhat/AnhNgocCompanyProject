namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.News.Dto.Param
{
    public class GetListNewsParamDto : PagingRequestDto
    {
        public string Search { get; set; } = string.Empty;
    }
}
