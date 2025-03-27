namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductDetailViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetListProductUseCase useCase;
        public ProductDetailViewComponent(IGetListProductUseCase useCase)
        {
            this.useCase = useCase;
        }
        public  Task<IViewComponentResult> InvokeAsync()
        {
           
            //var data = await this.useCase.Execute(null);
            return Task.FromResult(RenderViewComponent("Product", "ProductDetail"));
        }
    }
}
