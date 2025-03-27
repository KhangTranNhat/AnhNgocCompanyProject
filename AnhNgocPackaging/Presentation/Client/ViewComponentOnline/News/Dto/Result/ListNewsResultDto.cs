namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.News.Dto.Result
{
    public class ListNewsResultDto : PagingResponseDto
    {
        public IEnumerable<ItemListNewsResultDto> Items { get; set; } = Enumerable.Empty<ItemListNewsResultDto>();
    }
    public class ItemListNewsResultDto
    {
        public string Id { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } 
    }
}
