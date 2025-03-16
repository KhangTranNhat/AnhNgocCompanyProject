namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner
{
    public class BannerGridViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetDataBannerGridViewComponentUseCase useCase;
        public BannerGridViewComponent(IGetDataBannerGridViewComponentUseCase useCase)
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
