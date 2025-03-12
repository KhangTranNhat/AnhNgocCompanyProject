namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Footer
{
    public class FooterViewComponent : BaseClientViewComponentOnline
    {
        public FooterViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Footer", "Default");
        }
    }
}
