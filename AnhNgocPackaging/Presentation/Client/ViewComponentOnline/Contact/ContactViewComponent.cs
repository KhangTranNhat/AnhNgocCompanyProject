namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Contact
{
    public class ContactViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync(CompanyContactResultDto param)
        {
            return Task.FromResult(RenderViewComponent("Contact", "Default", param));
        }
    }
}
