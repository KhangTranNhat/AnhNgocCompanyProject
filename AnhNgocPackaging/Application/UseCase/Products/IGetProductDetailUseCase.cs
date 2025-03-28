namespace AnhNgocPackaging.Application.UseCase.Products
{
    public interface IGetProductDetailUseCase
    {
        Task<ProductResultDto> Execute(GetProductParamDto param);
    }
}
