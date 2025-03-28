namespace AnhNgocPackaging.Domain.Entity
{
    public class ProductCategoryEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("parent_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Parent_id { get; set; } = null;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("slug")]
        public string Slug { get; set; } = string.Empty;

        [BsonElement("image")]
        public string Image { get; set; } = string.Empty;

        [BsonElement("priority")]
        public int Priority { get; set; }

        [BsonElement("total_product")]
        public int TotalProduct { get; set; }

        [BsonElement("is_menu")]
        public bool IsMenu { get; set; }
    }
}
