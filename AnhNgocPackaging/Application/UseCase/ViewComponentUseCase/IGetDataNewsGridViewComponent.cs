using AnhNgocPackaging.Presentation.Client.ViewComponentOnline.News.Dto.Result;

namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    public interface IGetDataNewsGridViewComponent
    {
        Task<ListNewsResultDto> Execute();
    }
}
