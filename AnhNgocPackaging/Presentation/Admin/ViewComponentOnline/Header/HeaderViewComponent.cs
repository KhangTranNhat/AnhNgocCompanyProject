namespace AnhNgocPackaging.Presentation.Admin.ViewComponentOnline.Header
{
    public class HeaderViewComponent : BaseAdminViewComponentOnline
    {
        public HeaderViewComponent()
        {

        }
        public  Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Header", "Defautl"));
        }
    }
}
