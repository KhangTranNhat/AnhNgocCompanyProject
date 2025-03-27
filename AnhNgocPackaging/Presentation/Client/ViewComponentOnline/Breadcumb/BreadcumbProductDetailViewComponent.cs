namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Breadcumb
{
    public class BreadcumbProductDetailViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Breadcumb", "BreadcumbProductDetail"));
        }
    }
}
