

namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    [ScopedService]
    public class GetDataLayoutViewComponentUseCase : IGetDataLayoutViewComponentUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<CompanyEntity> companyCollection;
        private readonly IMongoCollection<ProductCategoryEntity> productCategoryCollection;
        public GetDataLayoutViewComponentUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.companyCollection = context.Company;
            this.productCategoryCollection = context.ProductCategory;
        }
        public async Task<DataLayoutResultDto> Execute()
        {
            var dataReturnException = new DataLayoutResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var productCategories = await this.productCategoryCollection.Find(FilterDefinition<ProductCategoryEntity>.Empty).ToListAsync();
                var company = await this.companyCollection.Find(FilterDefinition<CompanyEntity>.Empty).FirstOrDefaultAsync();
              
                var dataReturn = new DataLayoutResultDto
                {
                    Company = this.mapper.Map<CompanyResultDto>(company)
                  
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
