namespace AnhNgocPackaging.Presentation.Client.Base
{
    public abstract class BaseClientViewComponentOnline : ViewComponent
    {
        private const string CLIENT_COMPONENT_PATH = "~/Views/Client/Component/";
        protected IViewComponentResult RenderViewComponent<TModel>(string componentName, string fileName, TModel? model)
        {
            string viewPath = Path.Combine(CLIENT_COMPONENT_PATH, componentName, $"{fileName}.cshtml");
            return View(viewPath, model);
        }
        protected IViewComponentResult RenderViewComponent(string componentName,string fileName)
        {
            string viewPath = Path.Combine(CLIENT_COMPONENT_PATH, componentName, $"{fileName}.cshtml");
            return View(viewPath);
        }
    }
}
