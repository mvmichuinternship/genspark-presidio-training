namespace azureProductWebApp.interfaces
{
    public interface IBlobService
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
        Task<string> GetImageUrlAsync(string imageName);
    }
}
