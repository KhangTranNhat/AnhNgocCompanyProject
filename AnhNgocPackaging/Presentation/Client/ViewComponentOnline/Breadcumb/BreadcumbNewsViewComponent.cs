namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Breadcumb
{
    public class BreadcumbNewsViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Breadcumb", "BreadcumbNews"));
        }
    }
}
