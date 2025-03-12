namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductFeaturedSliderViewComponent : BaseClientViewComponentOnline
    {
        public ProductFeaturedSliderViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Product", "ProductFeaturedSlider");
        }
    }
}
