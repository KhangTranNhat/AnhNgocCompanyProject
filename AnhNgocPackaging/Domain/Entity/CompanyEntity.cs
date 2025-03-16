namespace AnhNgocPackaging.Domain.Entity
{
    public class CompanyEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("contact")]
        public CompanyContactModel Contact { get; set; } = new CompanyContactModel();

        [BsonElement("employee_contacts")]
        public List<EmployeeContactInfoModel> EmployeeContacts { get; set; } = new List<EmployeeContactInfoModel>();

        [BsonElement("info")]
        public CompanyInfoModel Info { get; set; } = new CompanyInfoModel();

        [BsonElement("social_media")]
        public SocialMediaModel SocialMedia { get; set; } = new SocialMediaModel();

        [BsonElement("opening_hour_working")]
        public string OpeningHourWorking { get; set; } = string.Empty;


    }

    public class CompanyContactModel : ContactModel
    {
        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;
    }

    public class EmployeeContactInfoModel : ContactModel
    {
        [BsonElement("full_name")]
        public string FullName { get; set; } = string.Empty;

        [BsonElement("position")]
        public string Position { get; set; } = string.Empty;

        [BsonElement("avatar")]
        public string Avatar { get; set; } = string.Empty;

        [BsonElement("social_media")]
        public SocialMediaModel SocialMedia { get; set; } = new SocialMediaModel();
    }

    public class CompanyInfoModel
    {
        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("primary_logo")]
        public string PrimaryLogo { get; set; } = string.Empty;

        [BsonElement("secondary_logo")]
        public string SecondaryLogo { get; set; } = string.Empty;

        [BsonElement("favicon")]
        public string Favicon { get; set; } = string.Empty;

        [BsonElement("image")]
        public ImageModel Image { get; set; } = new ImageModel();

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("content")]
        public string Content { get; set; } = string.Empty;
    }
}
