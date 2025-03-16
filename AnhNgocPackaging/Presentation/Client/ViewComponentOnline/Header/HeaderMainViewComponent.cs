namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Header
{
    public class HeaderMainViewComponent : BaseClientViewComponentOnline
    {
        public HeaderMainViewComponent()
        {

        }
        public Task<IViewComponentResult> InvokeAsync(DataLayoutResultDto param)
        {
            return Task.FromResult(RenderViewComponent("Header", "HeaderMain", param));
        }
    }
}
