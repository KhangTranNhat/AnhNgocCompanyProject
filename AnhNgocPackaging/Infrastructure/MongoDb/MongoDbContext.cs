
namespace AnhNgocPackaging.Infrastructure.MongoDb
{
    [ScopedService]
    public class MongoDbContext
    {
        private readonly IMongoDatabase database;
        public MongoDbContext()
        {
            var connectionString = AppConfig.DatabaseConfig.ConnectionString;
            var databaseName = AppConfig.DatabaseConfig.DatabaseName;
            var mongoSettings = MongoClientSettings.FromConnectionString(connectionString);
            var client = new MongoClient(mongoSettings);
            database = client.GetDatabase(databaseName);
            CreateUniqueIndex();
        }
        public IMongoCollection<PolicyEntity> Policy => database.GetCollection<PolicyEntity>("policies");
        public IMongoCollection<BannerEntity> Banner => database.GetCollection<BannerEntity>("banners");
        public IMongoCollection<CompanyEntity> Company => database.GetCollection<CompanyEntity>("company");
        public IMongoCollection<ProductCategoryEntity> ProductCategory => database.GetCollection<ProductCategoryEntity>("product_categories");
        public IMongoCollection<ProductEntity> Product => database.GetCollection<ProductEntity>("products");
        public IMongoCollection<NewsEntity> News => database.GetCollection<NewsEntity>("news");
        public IMongoCollection<ComponentEntity> Component => database.GetCollection<ComponentEntity>("components");
        private void CreateUniqueIndex()
        {
            var indexProductKeys = Builders<ProductEntity>.IndexKeys.Text(p => p.Name);
            var indexProductModel = new CreateIndexModel<ProductEntity>(indexProductKeys);
            Product.Indexes.CreateOne(indexProductModel);

            var indexNewsKeys = Builders<NewsEntity>.IndexKeys.Text(p => p.Title);
            var indexNewsModel = new CreateIndexModel<NewsEntity>(indexNewsKeys);
            News.Indexes.CreateOne(indexNewsModel);
        }

    }
}
