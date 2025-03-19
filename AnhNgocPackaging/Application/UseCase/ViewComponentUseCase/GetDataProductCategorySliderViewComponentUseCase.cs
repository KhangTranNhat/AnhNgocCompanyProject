
namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    public class GetDataProductCategorySliderViewComponentUseCase : IGetDataProductCategorySliderViewComponentUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductCategoryEntity> collection;
        public GetDataProductCategorySliderViewComponentUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.collection = context.ProductCategory;
        }
        public async Task<ListProductCategoryResultDto> Execute()
        {
            var dataReturnException = new ListProductCategoryResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var productCategories = await this.collection.Find(FilterDefinition<ProductCategoryEntity>.Empty).ToListAsync();
                var dataReturn = new ListProductCategoryResultDto
                {
                    Items = this.mapper.Map<List<ItemListProductCategoryResultDto>>(productCategories)
                };
                return dataReturn;
            }
            catch (Exception ex)
            {
                dataReturnException.Errors.Add(new ErrorResponseDto
                {
                    Code = ex.GetType().Name,
                    Error = ex.Message
                });
            }
            return dataReturnException;
        }
    }
}
