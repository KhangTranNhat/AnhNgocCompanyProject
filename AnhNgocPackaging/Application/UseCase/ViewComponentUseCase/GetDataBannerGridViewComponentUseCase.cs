
namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    [ScopedService]
    public class GetDataBannerGridViewComponentUseCase : IGetDataBannerGridViewComponentUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<BannerEntity> collection;
        public GetDataBannerGridViewComponentUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.collection = context.Banner;
        }
        public async Task<ListBannerResultDto> Execute()
        {
            var dataReturnException = new ListBannerResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var banners = await this.collection.Find(x => x.IsGrid == true).ToListAsync();
                var dataReturn = new ListBannerResultDto
                {
                    Items = this.mapper.Map<List<ContentBannerResultDto>>(banners)
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
