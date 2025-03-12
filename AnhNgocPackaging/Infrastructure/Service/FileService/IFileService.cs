namespace AnhNgocPackaging.Infrastructure.Service.FileService
{
    public interface IFileService
    {
        bool DeleteFile(string path);
        Task<string> UploadFile(IFormFile file);
    }
}
