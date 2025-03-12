namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductBestSellerGridViewComponent : BaseClientViewComponentOnline
    {
        public ProductBestSellerGridViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("Product", "ProductBestSellerGrid");
        }
    }
}
