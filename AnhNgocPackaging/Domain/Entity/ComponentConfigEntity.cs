namespace AnhNgocPackaging.Domain.Entity
{

    public class ComponentConfigEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("type")]
        public ComponentType Type { get; set; }

        [BsonElement("config")]
        public ConfigModel? config { get; set; } = null;
    }

    public class ConfigModel
    {
    }

}
