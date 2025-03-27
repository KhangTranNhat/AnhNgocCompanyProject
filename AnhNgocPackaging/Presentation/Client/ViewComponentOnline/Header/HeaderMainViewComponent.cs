namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Header
{
    public class HeaderMainViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync(HeaderMainParamDto param)
        {
            return Task.FromResult(RenderViewComponent("Header", "HeaderMain", param));
        }
    }
}
