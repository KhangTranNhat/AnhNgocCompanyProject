
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Sidebar
{
    public class SidebarViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetListProductCategoryUseCase useCase;
        public SidebarViewComponent(IGetListProductCategoryUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Sidebar", "Default", data);
        }
    }
}
