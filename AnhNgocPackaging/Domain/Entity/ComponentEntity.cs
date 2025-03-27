namespace AnhNgocPackaging.Domain.Entity
{

    public class ComponentEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("type")]
        [BsonRepresentation(BsonType.String)]
        public required ComponentType Type { get; set; }

        [BsonElement("slug")]
        public string Slug { get; set; } = string.Empty;

        [BsonElement("component_name")]
        public string ComponentName { get; set; } = string.Empty;

        [BsonElement("priorty")]
        public int Priorty { get; set; } = 0;

        [BsonElement("config")]
        public ConfigModel Config { get; set; } = new ConfigModel();

        [BsonElement("content")]
        public ContentModel Content { get; set; } = new ContentModel();

        [BsonElement("is_active")]
        public bool IsActive { get; set; } = true;
        [BsonElement("extra")]
        public Dictionary<string, object>? Extra { get; set; } = new Dictionary<string, object>();
    }

    public class ConfigModel
    {
        [BsonElement("title_color")]
        public string TitleColor { get; set; } = string.Empty;

        [BsonElement("description_color")]
        public string DescriptionColor { get; set; } = string.Empty;

        [BsonElement("background_color")]
        public string BackgroundColor { get; set; } = string.Empty;

        [BsonElement("button_background")]
        public string ButtonBackground { get; set; } = string.Empty;

        [BsonElement("button_text_color")]
        public string ButtonTextColor { get; set; } = string.Empty;
    }
    public class ContentModel
    {
        [BsonElement("title")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("sub_title")]
        public string SubTitle { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("background")]
        public string Background { get; set; } = string.Empty;

        [BsonElement("button")]
        public string Button { get; set; } = string.Empty;

        [BsonElement("button_text")]
        public string ButtonText { get; set; } = string.Empty;

        
    }
}
