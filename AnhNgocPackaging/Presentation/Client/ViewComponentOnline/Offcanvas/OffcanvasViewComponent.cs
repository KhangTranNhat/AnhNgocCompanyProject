namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Offcanvas
{
    public class OffcanvasViewComponent : BaseClientViewComponentOnline
    {
        public  Task<IViewComponentResult> InvokeAsync(OffcanvasParamDto param)
        {
            return Task.FromResult(RenderViewComponent("Offcanvas", "Default", param));
        }
    }
}
