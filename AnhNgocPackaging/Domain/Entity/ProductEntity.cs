namespace AnhNgocPackaging.Domain.Entity
{
    public class ProductEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("slug")]
        public string Slug { get; set; } = string.Empty;

        [BsonElement("product_category_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ProductCategoryId { get; set; } = null;

        [BsonElement("product_category_ids")]
        [BsonRepresentation(BsonType.ObjectId)]
        public List<string>? ProductCategoryIds { get; set; } = null;

        [BsonElement("price")]
        public string Price { get; set; } = string.Empty;

        [BsonElement("final_price")]
        public string FinalPrice { get; set; } = string.Empty;

        [BsonElement("image")]
        public string Image { get; set; } = string.Empty;

        [BsonElement("discount_percentage")]
        public string DiscountPercentage { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("content")]
        public string Content { get; set; } = string.Empty;

        [BsonElement("types")]
        [BsonRepresentation(BsonType.String)]
        public List<ProductType> Types { get; set; } = new List<ProductType>();
    }
}
