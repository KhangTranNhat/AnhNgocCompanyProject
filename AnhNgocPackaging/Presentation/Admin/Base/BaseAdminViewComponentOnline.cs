namespace AnhNgocPackaging.Presentation.Admin.Base
{
    public abstract class BaseAdminViewComponentOnline : ViewComponent
    {
        private const string CLIENT_COMPONENT_PATH = "~/Views/Admin/Component/";
        protected IViewComponentResult RenderViewComponent<TModel>(string componentName, string fileName, TModel? model)
        {
            string viewPath = Path.Combine(CLIENT_COMPONENT_PATH, componentName, $"{fileName}.cshtml");
            return View(viewPath, model);
        }
        protected IViewComponentResult RenderViewComponent(string componentName, string fileName)
        {
            string viewPath = Path.Combine(CLIENT_COMPONENT_PATH, componentName, $"{fileName}.cshtml");
            return View(viewPath);
        }
    }
}
