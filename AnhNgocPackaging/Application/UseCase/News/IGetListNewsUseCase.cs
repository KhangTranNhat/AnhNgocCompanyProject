
namespace AnhNgocPackaging.Application.UseCase.News
{
    public interface IGetListNewsUseCase
    {
        Task<ListNewsResultDto> Execute(GetListNewsParamDto param);
    }
}
