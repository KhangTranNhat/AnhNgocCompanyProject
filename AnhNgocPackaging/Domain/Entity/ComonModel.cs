namespace AnhNgocPackaging.Domain.Entity
{


    public class ContactModel
    {
        // Phone
        [BsonElement("primary_phone")]
        public string PrimaryPhone { get; set; } = string.Empty;

        [BsonElement("secondary_phone")]
        public string SecondaryPhone { get; set; } = string.Empty;

        // Email
        [BsonElement("primary_email")]
        public string PrimaryEmail { get; set; } = string.Empty;

        [BsonElement("secondary_email")]
        public string SecondaryEmail { get; set; } = string.Empty;

        // Address
        [BsonElement("primary_address")]
        public string PrimaryAddress { get; set; } = string.Empty;

        [BsonElement("secondary_address")]
        public string SecondaryAddress { get; set; } = string.Empty;
    }

    public class SocialMediaModel
    {

        [BsonElement("facebook")]
        public string Facebook { get; set; } = string.Empty;

        [BsonElement("linkedin")]
        public string LinkedIn { get; set; } = string.Empty;

        [BsonElement("youtube")]
        public string YouTube { get; set; } = string.Empty;

        [BsonElement("zalo")]
        public string Zalo { get; set; } = string.Empty;

        [BsonElement("tiktok")]
        public string TikTok { get; set; } = string.Empty;

        [BsonElement("instagram")]
        public string Instagram { get; set; } = string.Empty;
    }
    public class ImageModel
    {
        [BsonElement("background")]
        public string Background { get; set; } = string.Empty;

        [BsonElement("primary")]
        public string Primary { get; set; } = string.Empty;

        [BsonElement("secondary")]
        public string Secondary { get; set; } = string.Empty;

        [BsonElement("shapes")]
        public List<string> Shapes { get; set; } = new List<string>();
    }
}
