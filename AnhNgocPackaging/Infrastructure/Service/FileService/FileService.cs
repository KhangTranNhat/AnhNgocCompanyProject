namespace AnhNgocPackaging.Infrastructure.Service.FileService
{
    [ScopedService]
    public class FileService : IFileService
    {
        private readonly string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
        public bool DeleteFile(string path)
        {
            try
            {

                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }
                var fullPath = Path.Combine(uploadPath, path.TrimStart('/'));


                if (!File.Exists(fullPath))
                {
                    return true;
                }

                File.Delete(fullPath);

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<string> UploadFile(IFormFile file)
        {
            try
            {
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(uploadPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return $"/uploads/{fileName}";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
