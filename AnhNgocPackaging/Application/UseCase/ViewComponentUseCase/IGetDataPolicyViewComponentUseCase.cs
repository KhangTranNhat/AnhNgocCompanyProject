namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    public interface IGetDataPolicyViewComponentUseCase
    {
        Task<ListPolicyResultDto> Execute();
    }
}
