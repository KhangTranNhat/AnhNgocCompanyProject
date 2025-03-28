﻿namespace AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product.Dto.Result
{
    public class ProductResultDto : BaseResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string ProductCategoryId { get; set; } = string.Empty;
        public string ProductCategoryName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string FinalPrice { get; set; } = string.Empty;
    }
}
