namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.AboutUs
{
    public class AboutUsViewComponent : BaseClientViewComponentOnline
    {
        public AboutUsViewComponent()
        {
        }
        public  Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("AboutUs", "Default"));
        }
    }
}
