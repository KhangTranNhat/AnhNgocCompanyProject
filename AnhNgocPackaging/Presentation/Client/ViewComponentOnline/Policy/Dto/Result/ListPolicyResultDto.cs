namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Policy.Dto.Result
{
    public class ListPolicyResultDto : PagingResponseDto
    {
        public ComponentConfigResultDto? Config { get; set; } = null;
        public IEnumerable<ContentPolicyResultDto> Items { get; set; } = Enumerable.Empty<ContentPolicyResultDto>();
    }
    public class ContentPolicyResultDto
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Priority { get; set; }
    }
}
