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
            var type = (int)param.Extra["type"];
            var paramProduct = new GetListProductParamDto();
            switch (type)
            {
                case 1:
                    paramProduct.Type = ProductType.TYPE_1;
                    break;
                case 2:
                    paramProduct.Type = ProductType.TYPE_2;
                    break;
                case 3:
                    paramProduct.Type = ProductType.TYPE_3;
                    break;
                case 4:
                    paramProduct.Type = ProductType.TYPE_4;
                    break;
                case 5:
                    paramProduct.Type = ProductType.TYPE_5;
                    break;
            }

            var data =await this.useCase.Execute(paramProduct);
            return RenderViewComponent("Product", param.ComponentName + type, data);
        }
    }
}
