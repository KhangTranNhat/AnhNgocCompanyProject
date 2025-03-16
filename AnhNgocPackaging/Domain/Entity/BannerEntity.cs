

namespace AnhNgocPackaging.Domain.Entity
{
    public class BannerEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("primary_title")]
        public string PrimaryTitle { get; set; } = string.Empty;

        [BsonElement("secondary_title")]
        public string SecondaryTitle { get; set; } = string.Empty;

        [BsonElement("button")]
        public string Button { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("url")]
        public string Url { get; set; } = string.Empty;

        [BsonElement("image")]
        public ImageModel Image { get; set; } = new ImageModel();

        [BsonElement("is_grid")]
        public bool IsGrid { get; set; }
    }
}
