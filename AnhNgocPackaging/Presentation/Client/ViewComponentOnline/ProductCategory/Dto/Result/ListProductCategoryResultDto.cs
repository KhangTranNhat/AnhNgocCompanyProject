namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.ProductCategory.Dto.Result
{
    public class ListProductCategoryResultDto : PagingResponseDto
    {
        public IEnumerable<ItemListProductCategoryResultDto> Items { get; set; } = Enumerable.Empty<ItemListProductCategoryResultDto>();
    }
    public class ItemListProductCategoryResultDto : PagingResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string? Parent_id { get; set; } = null;
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Priority { get; set; }
    }
}
