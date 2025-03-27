namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.ProductCategory.Dto.Result
{
    public class ListProductCategoryResultDto : PagingResponseDto
    {
        public IEnumerable<ItemListProductCategoryResultDto> Items { get; set; } = Enumerable.Empty<ItemListProductCategoryResultDto>();
    }
    public class ItemListProductCategoryResultDto 
    {
        public string Id { get; set; } = string.Empty;
        public string? Parent_id { get; set; } = null;
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Priority { get; set; }
        public int? TotalProduct { get; set; } = 0;
        public List<ItemListProductCategoryResultDto> Children { get; set; } = new List<ItemListProductCategoryResultDto>();
    }
}
