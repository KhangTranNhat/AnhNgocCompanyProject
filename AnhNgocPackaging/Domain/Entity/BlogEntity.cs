namespace AnhNgocPackaging.Domain.Entity
{
    public class BlogEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("image")]
        public string Image { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("primary_title")]
        public string PrimaryTitle { get; set; } = string.Empty;

        [BsonElement("content")]
        public string Content { get; set; } = string.Empty;

        [BsonElement("uploaded_at")]
        public string UploadedAt { get; set; } = string.Empty;
    }
}
