namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Dto.Result
{
    public class ImageResultDto
    {
        public string Background { get; set; } = string.Empty;
        public string Primary { get; set; } = string.Empty;
        public List<string> Shapes { get; set; } = new List<string>();
    }

    public class ContactResultDto
    {
        // Phone
        public string PrimaryPhone { get; set; } = string.Empty;

        public string SecondaryPhone { get; set; } = string.Empty;

        // Email
        public string PrimaryEmail { get; set; } = string.Empty;

        public string SecondaryEmail { get; set; } = string.Empty;

        // Address
        public string PrimaryAddress { get; set; } = string.Empty;

        public string SecondaryAddress { get; set; } = string.Empty;
    }

    public class SocialMediaResultDto
    {

        public string Facebook { get; set; } = string.Empty;

        public string LinkedIn { get; set; } = string.Empty;

        public string YouTube { get; set; } = string.Empty;

        public string Zalo { get; set; } = string.Empty;

        public string TikTok { get; set; } = string.Empty;

        public string Instagram { get; set; } = string.Empty;
    }
}
