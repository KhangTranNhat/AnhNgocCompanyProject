
namespace AnhNgocPackaging.Application.UseCase.Products
{
    public class GetProductDetailUseCase : IGetProductDetailUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductEntity> productsCollection;
        private readonly IMongoCollection<ProductCategoryEntity> productCategoriesCollection;
        public GetProductDetailUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.productsCollection = context.Product;
            this.productCategoriesCollection = context.ProductCategory;
        }
        public async Task<ProductResultDto> Execute(GetProductParamDto param)
        {
            var dataReturnException = new ProductResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var product = await this.productsCollection.Find(x => x.Slug.Equals(param.ProductSlug)).FirstOrDefaultAsync();
                if(product == null)
                {
                    return dataReturnException;
                }
                var productId = product.ProductCategoryId;
                var productCategory = await this.productCategoriesCollection.Find(x => x.Id == productId).FirstOrDefaultAsync();

                var dataReturn = this.mapper.Map<ProductResultDto>(product);
                dataReturn.ProductCategoryName = productCategory.Name;
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
