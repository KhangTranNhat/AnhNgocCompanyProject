
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Policy
{
    public class PolicyGridViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetDataPolicyViewComponentUseCase useCase;
        public PolicyGridViewComponent(IGetDataPolicyViewComponentUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Policy", "PolicyGrid", data);
        }
    }
}
