

namespace AnhNgocPackaging.Presentation.Client.PageOnline
{
    public class PageOnlineController : BaseClientPageController
    {
        private readonly IGetCompanyUseCase getCompanyUseCase;
        private readonly IGetListComponentUseCase getListComponentUseCase;
        public PageOnlineController(IGetCompanyUseCase getCompanyUseCase, IGetListComponentUseCase getListComponentUseCase)
        {
            this.getCompanyUseCase = getCompanyUseCase;
            this.getListComponentUseCase = getListComponentUseCase;
        }
        [HttpGet, ActionName("Home")]
        [Route("")]
        public async Task<IActionResult> HomePage()
        {
            var data = await this.getListComponentUseCase.Execute();
            return RenderPageView("Home", data);
        }
        [HttpGet, ActionName("AboutUs")]
        [Route("gioi-thieu-ve-anh-ngoc-packaging")]
        public IActionResult AboutUsPage()
        {
            return RenderPageView("AboutUs");
        }

        [HttpGet, ActionName("Product")]
        [Route("san-pham-bao-bi")]
        public IActionResult ProductPage(GetListProductParamDto param)
        {
            return RenderPageView("Product", param);
        }

        [HttpGet, ActionName("ProductDetail")]
        [Route("san-pham-bao-bi/{slug}")]
        public IActionResult ProductDetailPage(GetProductParamDto param)
        {
            return RenderPageView("ProductDetail", param);
        }

        [HttpGet, ActionName("News")]
        [Route("tin-tuc")]
        public IActionResult NewsPage(GetListNewsParamDto param)
        {
            return RenderPageView("News", param);
        }


        [HttpGet, ActionName("NewsDetail")]
        [Route("tin-tuc/{slug}")]
        public IActionResult NewsDetailPage()
        {
            return RenderPageView("NewsDetail");
        }

        [HttpGet, ActionName("Contact")]
        [Route("lien-he")]
        public async Task<IActionResult> ContactPage()
        {
            var data = await this.getCompanyUseCase.Execute();
            return RenderPageView("Contact", data);
        }

       
    }
}
