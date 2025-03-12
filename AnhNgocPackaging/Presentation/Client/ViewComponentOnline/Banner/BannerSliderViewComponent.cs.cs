namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner
{
    public class BannerSliderViewComponent : BaseClientViewComponentOnline
    {
        public BannerSliderViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Banner", "BannerSlider");
        }
    }
}
