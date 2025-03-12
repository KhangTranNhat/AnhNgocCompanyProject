namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Header
{
    public class HeaderMainViewComponent : BaseClientViewComponentOnline
    {
        public HeaderMainViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Header", "HeaderMain");
        }
    }
}
