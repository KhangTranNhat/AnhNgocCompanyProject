namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductBestSellerGridViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetDataProductViewComponentUseCase useCase;
        public ProductBestSellerGridViewComponent(IGetDataProductViewComponentUseCase useCase)
        {
            this.useCase = useCase;
        }
        public  async Task<IViewComponentResult> InvokeAsync()
        {
            var data =await this.useCase.Execute(ProductType.BEST_SELLERS);
            return RenderViewComponent("Product", "ProductBestSellerGrid", data);
        }
    }
}
