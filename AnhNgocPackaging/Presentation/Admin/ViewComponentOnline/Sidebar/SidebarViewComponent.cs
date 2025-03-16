namespace AnhNgocPackaging.Presentation.Admin.ViewComponentOnline.Sidebar
{
    public class SidebarViewComponent : BaseAdminViewComponentOnline
    {
        public SidebarViewComponent()
        {

        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Sidebar", "Default"));
        }
    }
}
