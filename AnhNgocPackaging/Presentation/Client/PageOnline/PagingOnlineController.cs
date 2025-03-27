namespace AnhNgocPackaging.Presentation.Client.PageOnline
{
    [Route("load-more")]
    public class PagingOnlineController : Controller
    {
        [HttpGet]
        [Route("products")]
        public IActionResult ProductPaging(GetListProductParamDto param)
        {
            return ViewComponent("ProductGrid", param);
        }
        [HttpGet]
        [Route("news")]
        public IActionResult NewsPaging()
        {
            return ViewComponent("NewsGrid2");
        }
    }
}
