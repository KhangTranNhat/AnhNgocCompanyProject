
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
        public IMongoCollection<PolicyEntity> Policy => database.GetCollection<PolicyEntity>("policy");
        public IMongoCollection<BannerEntity> Banner => database.GetCollection<BannerEntity>("banner");
        public IMongoCollection<CompanyEntity> Company => database.GetCollection<CompanyEntity>("company");
        public IMongoCollection<ProductCategoryEntity> ProductCategory => database.GetCollection<ProductCategoryEntity>("product_category");
        public IMongoCollection<ComponentConfigEntity> ComponentConfig => database.GetCollection<ComponentConfigEntity>("component_config");
        private void CreateUniqueIndex()
        {



        }

    }
}
