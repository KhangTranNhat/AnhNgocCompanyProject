namespace AnhNgocPackaging.Application.UseCase.Banner
{
    public interface IGetListBannerUseCase
    {
        Task<ListBannerResultDto> Execute();
    }
}
