namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Footer
{
    public class FooterViewComponent : BaseClientViewComponentOnline
    {
        public FooterViewComponent()
        {

        }
        public Task<IViewComponentResult> InvokeAsync(DataLayoutResultDto param)
        {
            return Task.FromResult(RenderViewComponent("Footer", "Default", param));
        }
    }
}
