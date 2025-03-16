namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductFeaturedSliderViewComponent : BaseClientViewComponentOnline
    {
        public ProductFeaturedSliderViewComponent()
        {

        }
        public  Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Product", "ProductFeaturedSlider"));
        }
    }
}
