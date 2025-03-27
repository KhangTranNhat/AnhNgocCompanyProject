namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Breadcumb
{
    public class BreadcumbNewsDetailContactViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Breadcumb", "BreadcumbNewsDetail"));
        }
    }
}
