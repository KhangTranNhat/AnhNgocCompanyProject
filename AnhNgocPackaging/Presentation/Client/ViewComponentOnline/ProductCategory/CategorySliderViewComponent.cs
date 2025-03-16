namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.ProductCategory
{
    public class ProductCategorySliderViewComponent : BaseClientViewComponentOnline
    {
        public ProductCategorySliderViewComponent()
        {

        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("ProductCategory", "ProductCategorySlider"));
        }
    }
}
