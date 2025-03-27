namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner
{
    public class BannerViewComponent : BaseClientViewComponentOnline
    {
        public BannerViewComponent()
        {
        }
        public Task<IViewComponentResult> InvokeAsync(ComponentResultDto param)
        {
            return Task.FromResult(RenderViewComponent("Banner", "Banner", param));
        }
    }
}
