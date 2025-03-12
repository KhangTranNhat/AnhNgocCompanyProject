namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner
{
    public class BannerGridViewComponent : BaseClientViewComponentOnline
    {
        public BannerGridViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Banner", "BannerGrid");
        }
    }
}
