namespace AnhNgocPackaging.Presentation.Admin.Base
{
    public abstract class BaseAdminPageController : Controller
    {
        private const string CLIENT_PAGE_PATH = "~/Views/Client/Page/";
        protected IActionResult RenderPageView<TModel>(string pageFolder, string pageName ,TModel? model)
        {
            string viewPath = Path.Combine(CLIENT_PAGE_PATH, pageFolder, $"{pageName}.cshtml");
            return View(viewPath, model);
        }

        protected IActionResult RenderPageView(string pageFolder, string pageName)
        {
            string viewPath = Path.Combine(CLIENT_PAGE_PATH, pageFolder, $"{pageName}.cshtml");
            return View(viewPath);
        }
    }
}
