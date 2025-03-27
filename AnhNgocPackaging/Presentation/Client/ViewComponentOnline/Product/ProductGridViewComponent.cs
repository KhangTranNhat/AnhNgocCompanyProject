
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductGridViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetListProductUseCase useCase;
        public ProductGridViewComponent(IGetListProductUseCase useCase)
        {
            this.useCase = useCase;
        }
        public  async Task<IViewComponentResult> InvokeAsync(GetListProductParamDto param)
        {
            var data =await this.useCase.Execute(param ?? new GetListProductParamDto() );
            return RenderViewComponent("Product", "ProductGrid", data);
        }
    }
}
