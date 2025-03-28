
namespace AnhNgocPackaging.Application.UseCase.ProductCategory
{
    [ScopedService]
    public class GetListProductCategoryUseCase : IGetListProductCategoryUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductCategoryEntity> productCategoryCollection;
        public GetListProductCategoryUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.productCategoryCollection = context.ProductCategory;
        }
        public async Task<ListProductCategoryResultDto> Execute()
        {
            var dataReturnException = new ListProductCategoryResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var productCategories = await this.productCategoryCollection.Find(x=> x.IsMenu == true).ToListAsync();
                var categoryDtos = productCategories.Select(c => new ItemListProductCategoryResultDto
                {
                    Id = c.Id,
                    Parent_id = c.Parent_id,
                    Name = c.Name,
                    Slug = c.Slug,
                    Image = c.Image,
                    Priority = c.Priority,
                    TotalProduct = c.TotalProduct
                }).ToList();
                var dataReturn = new ListProductCategoryResultDto
                {
                    Items = BuildCategoryTree(categoryDtos),
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

        private List<ItemListProductCategoryResultDto> BuildCategoryTree(List<ItemListProductCategoryResultDto> categories, string? parentId = null)
        {
            return categories
                .Where(c => c.Parent_id == parentId) 
                .Select(c => new ItemListProductCategoryResultDto
                {
                    Id = c.Id,
                    Parent_id = c.Parent_id,
                    Name = c.Name,
                    Slug = c.Slug,
                    Image = c.Image,
                    Priority = c.Priority,
                    TotalProduct = c.TotalProduct,
                    Children = BuildCategoryTree(categories, c.Id)
                })
                .OrderBy(c => c.Priority)
                .ToList();
        }
    }
}
