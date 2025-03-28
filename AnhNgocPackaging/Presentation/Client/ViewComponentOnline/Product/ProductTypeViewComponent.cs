namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductTypeViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetListProductUseCase useCase;
        public ProductTypeViewComponent(IGetListProductUseCase useCase)
        {
            this.useCase = useCase;
        }
        public  async Task<IViewComponentResult> InvokeAsync(ComponentResultDto param)
        {
            var componentView = param.Extra["component_view"] as string;
            var productCategorySlug = param.Extra["product_category_slug"] as string;
            var paramProduct = new GetListProductParamDto { 
                CategorySlug = productCategorySlug ?? ""
            };

            var data =await this.useCase.Execute(paramProduct);
            data.Component = param;
            return RenderViewComponent("Product", componentView ?? "ProductType1", data);
        }
    }
}
