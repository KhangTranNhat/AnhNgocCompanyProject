namespace AnhNgocPackaging.Domain.Entity
{
    public class ProductEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("product_category_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductCategoryId { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("image")]
        public string Image { get; set; } = string.Empty;

        [BsonElement("price")]
        public string Price { get; set; } = string.Empty;

        [BsonElement("sales_price")]
        public string SalesPrice { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("content")]
        public string Ccontent { get; set; } = string.Empty;
    }
}
