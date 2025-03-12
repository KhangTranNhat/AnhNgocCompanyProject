namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Header
{
    public class HeaderStickyViewComponent : BaseClientViewComponentOnline
    {
        public HeaderStickyViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Header", "HeaderSticky");
        }
    }
}
