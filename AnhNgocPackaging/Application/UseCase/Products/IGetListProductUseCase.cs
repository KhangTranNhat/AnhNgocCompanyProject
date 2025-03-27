
namespace AnhNgocPackaging.Application.UseCase.Products
{
    public interface IGetListProductUseCase
    {
        Task<ListProductResultDto> Execute(GetListProductParamDto param);
    }
}
