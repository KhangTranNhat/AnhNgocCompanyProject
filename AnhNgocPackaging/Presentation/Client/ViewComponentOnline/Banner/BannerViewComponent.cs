namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner
{
    public class BannerViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetDataBannerViewComponentUseCase useCase;
        public BannerViewComponent(IGetDataBannerViewComponentUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Banner", "Banner", data);
        }
    }
}
