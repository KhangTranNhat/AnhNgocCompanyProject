﻿namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product
{
    public class ProductFeaturedSliderViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetDataProductViewComponentUseCase useCase;
        public ProductFeaturedSliderViewComponent(IGetDataProductViewComponentUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute(ProductType.BEST_SELLERS);
            return RenderViewComponent("Product", "ProductFeaturedSlider", data);
        }
    }
}
