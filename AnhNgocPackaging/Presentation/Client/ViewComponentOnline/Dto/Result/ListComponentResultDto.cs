namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Dto.Result
{

    public class ListComponentResultDto : PagingResponseDto
    {
        public IEnumerable<ComponentResultDto> Items { get; set; } = Enumerable.Empty<ComponentResultDto>();
    }
    public class ComponentResultDto
    {
        public string Id { get; set; } = string.Empty;
        public  ComponentType Type { get; set; }
        public int Priorty { get; set; } 
        public string Slug { get; set; } = string.Empty;
        public string ComponentName { get; set; } = string.Empty;
        public ConfigModel Config { get; set; } = new ConfigModel();
        public ContentModel Content { get; set; } = new ContentModel();
        public bool IsActive { get; set; } = true;
        public Dictionary<string, object> Extra { get; set; } = new Dictionary<string, object>();

    }
    public class ConfigResultDto
    {
        public string TitleColor { get; set; } = string.Empty;
        public string SubTitleColor { get; set; } = string.Empty;
        public string DescriptionColor { get; set; } = string.Empty;
        public string BackgroundColor { get; set; } = string.Empty;
        public string ButtonBackground { get; set; } = string.Empty;
        public string ButtonTextColor { get; set; } = string.Empty;
    }
    public class ContentResultDto
    {
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Background { get; set; } = string.Empty;
        public string Button { get; set; } = string.Empty;
        public string ButtonText { get; set; } = string.Empty;
    }
}
