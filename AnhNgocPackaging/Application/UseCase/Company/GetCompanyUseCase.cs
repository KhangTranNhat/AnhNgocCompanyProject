
namespace AnhNgocPackaging.Application.UseCase.Company
{
    [ScopedService]
    public class GetCompanyUseCase : IGetCompanyUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<CompanyEntity> companyCollection;
        public GetCompanyUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.companyCollection = context.Company;
        }
        public async Task<CompanyResultDto> Execute()
        {
            var dataReturnException = new CompanyResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var company = await this.companyCollection.Find(FilterDefinition<CompanyEntity>.Empty).FirstOrDefaultAsync();
                var dataReturn = this.mapper.Map<CompanyResultDto>(company);
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
