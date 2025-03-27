namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.AboutUs
{
    public class AboutUsViewComponent : BaseClientViewComponentOnline
    {
        public AboutUsViewComponent()
        {
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("AboutUs", "Default");
        }
    }
}
