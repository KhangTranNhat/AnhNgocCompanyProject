namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.News
{
    public class NewsGridViewComponent : BaseClientViewComponentOnline
    {
        public NewsGridViewComponent()
        {

        }
        public  Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("News", "NewsGrid"));
        }
    }
}
