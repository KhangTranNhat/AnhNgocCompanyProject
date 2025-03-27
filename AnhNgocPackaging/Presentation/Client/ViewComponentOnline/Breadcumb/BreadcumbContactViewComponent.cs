namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Breadcumb
{
    public class BreadcumbContactViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Breadcumb", "BreadcumbContact"));
        }
    }
}
