namespace AnhNgocPackaging.Presentation.Client.PageOnline
{
    public class PageOnlineController : BaseClientPageController
    {

        public PageOnlineController()
        {

        }
        [HttpGet, ActionName("Home")]
        public IActionResult HomePage()
        {
            return RenderPageView("Home");
        }
    }
}
