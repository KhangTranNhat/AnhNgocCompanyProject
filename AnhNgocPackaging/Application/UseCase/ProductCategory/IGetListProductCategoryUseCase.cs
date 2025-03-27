namespace AnhNgocPackaging.Application.UseCase.ProductCategory
{
    public interface IGetListProductCategoryUseCase
    {
        Task<ListProductCategoryResultDto> Execute();
    }
}
