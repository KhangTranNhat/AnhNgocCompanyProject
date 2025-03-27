namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Breadcumb
{
    public class BreadcumbAboutUsViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Breadcumb", "BreadcumbAboutUs"));
        }
    }
}
