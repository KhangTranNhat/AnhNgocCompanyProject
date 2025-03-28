namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product.Dto.Param
{
    public class GetListProductParamDto : PagingRequestDto
    {
        [FromQuery(Name = "search")]
        public string Search { get; set; } = string.Empty;

        [FromQuery(Name ="danh-muc")]
        public string CategorySlug { get; set; } = string.Empty;
    }
}
