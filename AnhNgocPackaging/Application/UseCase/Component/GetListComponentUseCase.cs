
namespace AnhNgocPackaging.Application.UseCase.Component
{
    [ScopedService]
    public class GetListComponentUseCase : IGetListComponentUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ComponentEntity> componentCollection;
        public GetListComponentUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.componentCollection = context.Component;
        }
        public async Task<ListComponentResultDto> Execute()
        {
            var dataReturnException = new ListComponentResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
               
                var news = await this.componentCollection.Find(x => x.IsActive == true).ToListAsync();
                var dataReturn = new ListComponentResultDto
                {
                    Items = this.mapper.Map<List<ComponentResultDto>>(news)
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
