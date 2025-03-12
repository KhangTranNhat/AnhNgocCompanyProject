namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Offcanvas
{
    public class OffcanvasViewComponent : BaseClientViewComponentOnline
    {
        public OffcanvasViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Offcanvas", "Default");
        }
    }
}
