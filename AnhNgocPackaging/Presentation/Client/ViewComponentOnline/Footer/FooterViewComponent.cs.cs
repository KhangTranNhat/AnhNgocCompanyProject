
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Footer
{
    public class FooterViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync(FooterParamDto param)
        {
            return Task.FromResult(RenderViewComponent("Footer", "Default", param));
        }
    }
}
