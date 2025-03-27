
namespace AnhNgocPackaging.Application.UseCase.News
{
    [ScopedService]
    public class GetListNewsUseCase : IGetListNewsUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<NewsEntity> newsCollection;
        public GetListNewsUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.newsCollection = context.News;
        }
        public async Task<ListNewsResultDto> Execute(GetListNewsParamDto param)
        {
            var dataReturnException = new ListNewsResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var filter = Builders<NewsEntity>.Filter.Empty;
                if (!string.IsNullOrEmpty(param.Search))
                {
                    filter = Builders<NewsEntity>.Filter.And(
                    filter,
                     Builders<NewsEntity>.Filter.Text(param.Search)
                 );
                }
                var news = await this.newsCollection.Find(filter).Paging(param.Page, param.PageSize).ToListAsync();
                var dataReturn = new ListNewsResultDto
                {
                    Items = this.mapper.Map<List<ItemListNewsResultDto>>(news)
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
