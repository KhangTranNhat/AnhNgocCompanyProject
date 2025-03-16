namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Offcanvas
{
    public class OffcanvasViewComponent : BaseClientViewComponentOnline
    {
        public OffcanvasViewComponent()
        {

        }
        public  Task<IViewComponentResult> InvokeAsync(DataLayoutResultDto param)
        {
            return Task.FromResult(RenderViewComponent("Offcanvas", "Default", param));
        }
    }
}
