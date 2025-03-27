namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Pagination
{
    public class PaginationViewComponent : BaseClientViewComponentOnline
    {
        public Task<IViewComponentResult> InvokeAsync(PagingResponseDto param)
        {
            return Task.FromResult(RenderViewComponent("Pagination", "Default", param));
        }
    }
}
