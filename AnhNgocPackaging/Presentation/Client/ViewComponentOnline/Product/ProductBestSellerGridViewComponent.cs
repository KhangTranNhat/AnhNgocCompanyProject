namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductBestSellerGridViewComponent : BaseClientViewComponentOnline
    {
        public ProductBestSellerGridViewComponent()
        {

        }
        public  Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Product", "ProductBestSellerGrid"));
        }
    }
}
