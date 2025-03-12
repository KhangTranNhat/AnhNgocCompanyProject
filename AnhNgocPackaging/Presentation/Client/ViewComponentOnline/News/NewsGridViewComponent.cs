namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.News
{
    public class NewsGridViewComponent : BaseClientViewComponentOnline
    {
        public NewsGridViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return RenderViewComponent("News", "NewsGrid");
        }
    }
}
