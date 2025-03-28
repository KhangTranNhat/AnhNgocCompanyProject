﻿namespace AnhNgocPackaging.Presentation.Dto.Result
{
    public class BaseResponseDto
    {
        public List<ErrorResponseDto>? Errors { get; set; }
    }
    public class ErrorResponseDto
    {
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        [JsonPropertyName("error")]
        public string Error { get; set; } = string.Empty;
    }
}
