
namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.News
{
    public class NewsGridViewComponent : BaseClientViewComponentOnline
    {
        private readonly IGetListNewsUseCase useCase;
        public NewsGridViewComponent(IGetListNewsUseCase useCase)
        {
            this.useCase = useCase;
        }
        public  async Task<IViewComponentResult> InvokeAsync()
        {
            var param = new GetListNewsParamDto
            {
                Page = 1,
                PageSize = 4
            };
            var data = await this.useCase.Execute(param);
            return RenderViewComponent("News", "NewsGrid", data);
        }
    }
}
