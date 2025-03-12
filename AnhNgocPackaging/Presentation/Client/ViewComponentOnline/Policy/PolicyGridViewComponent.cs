namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Policy
{
    public class PolicyGridViewComponent : BaseClientViewComponentOnline
    {
        public PolicyGridViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Policy", "PolicyGrid");
        }
    }
}
