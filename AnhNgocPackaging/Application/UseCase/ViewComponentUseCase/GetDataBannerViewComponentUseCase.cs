

namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    [ScopedService]
    public class GetDataBannerViewComponentUseCase : IGetDataBannerViewComponentUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<BannerEntity> bannersCollection;
        private readonly IMongoCollection<ComponentConfigEntity> componentConfigCollection;
        public GetDataBannerViewComponentUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.bannersCollection = context.Banner;
            this.componentConfigCollection = context.ComponentConfig;
        }
        public async Task<BannerResultDto> Execute()
        {
            var dataReturnException = new BannerResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var banner = await this.bannersCollection.Find(x => x.IsGrid == false).FirstOrDefaultAsync();
                var dataReturn = new BannerResultDto
                {
                    Content = this.mapper.Map<ContentBannerResultDto>(banner)
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
