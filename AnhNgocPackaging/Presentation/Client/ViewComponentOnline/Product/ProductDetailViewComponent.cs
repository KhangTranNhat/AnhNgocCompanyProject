namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductDetailViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetProductDetailUseCase useCase;
        public ProductDetailViewComponent(IGetProductDetailUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async  Task<IViewComponentResult> InvokeAsync(GetProductParamDto param)
        {
            var data = await this.useCase.Execute(param);
            return RenderViewComponent("Product", "ProductDetail");
        }
    }
}
