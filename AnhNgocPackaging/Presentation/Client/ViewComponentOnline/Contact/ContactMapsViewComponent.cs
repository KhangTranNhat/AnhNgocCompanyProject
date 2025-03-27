namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Contact
{
    public class ContactMapsViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync(CompanyGoogleDataResultDto param)
        {
            return Task.FromResult(RenderViewComponent("Contact", "ContactMaps", param));
        }
    }
}
