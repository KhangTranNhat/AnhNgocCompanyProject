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

        [BsonElement("google")]
        public GoogleDataModel Google { get; set; } = new GoogleDataModel();

        [BsonElement("info")]
        public CompanyInfoModel Info { get; set; } = new CompanyInfoModel();
    }

    public class CompanyContactModel : ContactModel
    {
        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("opening_hour_working")]
        public string OpeningHourWorking { get; set; } = string.Empty;

        [BsonElement("social_media")]
        public SocialMediaModel SocialMedia { get; set; } = new SocialMediaModel();
    }

    public class GoogleDataModel
    {
        [BsonElement("title")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("keyword")]
        public string Keyword { get; set; } = string.Empty;

        [BsonElement("map")]
        public string Map { get; set; } = string.Empty;

        [BsonElement("analytics")]
        public string Analytics { get; set; } = string.Empty;

        [BsonElement("site_verification")]
        public string SiteVerification { get; set; } = string.Empty;
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

     
    }
}
