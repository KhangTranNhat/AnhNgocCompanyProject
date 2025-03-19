namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductTopCategorySliderViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetDataProductViewComponentUseCase useCase;
        public ProductTopCategorySliderViewComponent(IGetDataProductViewComponentUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute(ProductType.BEST_SELLERS);
            return RenderViewComponent("Product", "ProductTopCategorySlider", data);
        }
    }
}
