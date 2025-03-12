namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class CategorySliderViewComponent : BaseClientViewComponentOnline
    {
        public CategorySliderViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Category", "CategorySlider");
        }
    }
}
