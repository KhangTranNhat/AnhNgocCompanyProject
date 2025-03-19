namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    public interface IGetDataProductViewComponentUseCase
    {
        Task<ListProductResultDto> Execute(ProductType param);
    }
}
