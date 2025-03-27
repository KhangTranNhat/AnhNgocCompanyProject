
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner
{
    public class BannerGridViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetListBannerUseCase useCase;
        public BannerGridViewComponent(IGetListBannerUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Banner", "BannerGrid", data);
        }
    }
}
