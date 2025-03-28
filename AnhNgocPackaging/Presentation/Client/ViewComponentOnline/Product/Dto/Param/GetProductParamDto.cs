namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product.Dto.Param
{
    public class GetProductParamDto
    {
        [FromRoute(Name = "slug")]
        public string ProductSlug { get; set; } = string.Empty;
    }
}
