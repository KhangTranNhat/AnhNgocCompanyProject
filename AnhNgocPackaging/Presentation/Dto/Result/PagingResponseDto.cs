namespace AnhNgocPackaging.Presentation.Dto.Result
{
    public class PagingResponseDto : BaseResponseDto
    {
        public int TotalCount { get; set; } = 0;

        public int Page { get; set; } = 0;

        public int PageSize { get; set; } = 0;
        public string DataType { get; set; } = string.Empty;
    }
}
