
namespace AnhNgocPackaging.Application.UseCase.ViewComponentUseCase
{
    [ScopedService]
    public class GetDataProductViewComponentUseCase : IGetDataProductViewComponentUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductEntity> collection;
        public GetDataProductViewComponentUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.collection = context.Product;
        }
        public async Task<ListProductResultDto> Execute(ProductType param)
        {
            var dataReturnException = new ListProductResultDto { Errors = new List<ErrorResponseDto>() };
            try
            {

                var filter = Builders<ProductEntity>.Filter.Empty;

                //switch (param)
                //{
                //    case ProductType.BEST_SELLERS:
                //        filter = Builders<ProductEntity>.Filter.Eq(x => x.IsBestSellers, true);
                //        break;

                //    case ProductType.TOP_RATING:
                //        filter = Builders<ProductEntity>.Filter.Eq(x => x.IsTopRating, true);
                //        break;

                //    case ProductType.FEATURED:
                //        filter = Builders<ProductEntity>.Filter.Eq(x => x.IsFeatured, true);
                //        break;

                //    case ProductType.FAVORITE:
                //        filter = Builders<ProductEntity>.Filter.Eq(x => x.IsFavorite, true);
                //        break;

                //    default:
                //        throw new ArgumentException("Loại sản phẩm không hợp lệ.");
                //}

                var products = await this.collection.Find(filter).ToListAsync();
                var dataReturn = new ListProductResultDto
                {
                    Items = this.mapper.Map<List<ItemListProductResultDto>>(products)
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
