namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    [ScopedService]
    public class GetDataPolicyViewComponentUseCase : IGetDataPolicyViewComponentUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<PolicyEntity> collection;
        public GetDataPolicyViewComponentUseCase( IMapper mapper,MongoDbContext context)
        {
            this.mapper = mapper;
            this.collection = context.Policy;
        }
        public async Task<ListPolicyResultDto> Execute()
        {
            var dataReturnException = new ListPolicyResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var policy = await this.collection.Find(FilterDefinition<PolicyEntity>.Empty).ToListAsync();
                var dataReturn = new ListPolicyResultDto
                {
                    Items = this.mapper.Map<List<ContentPolicyResultDto>>(policy)
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
    public class GetDataPolicyViewComponentUseCaseProfile : Profile
    {
        public GetDataPolicyViewComponentUseCaseProfile()
        {
          
        }
    }
}
