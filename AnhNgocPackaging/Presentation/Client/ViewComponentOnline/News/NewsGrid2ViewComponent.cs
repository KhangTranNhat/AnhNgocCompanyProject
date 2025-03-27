
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.News
{
    public class NewsGrid2ViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetListNewsUseCase useCase;
        public NewsGrid2ViewComponent(IGetListNewsUseCase useCase)
        {
            this.useCase = useCase;
        }
        public  async Task<IViewComponentResult> InvokeAsync(GetListNewsParamDto param)
        {
            var data = await this.useCase.Execute(param);
            return RenderViewComponent("News", "NewsGrid", data);
        }
    }
}
