namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductFavoriteSliderViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetDataProductViewComponentUseCase useCase;
        public ProductFavoriteSliderViewComponent(IGetDataProductViewComponentUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute(ProductType.BEST_SELLERS);
            return RenderViewComponent("Product", "ProductFavoriteSlider", data);
        }
    }
}
