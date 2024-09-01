namespace SongsBackup.Services
{
    using Azure.Storage.Blobs.Models;
    using Azure.Storage.Blobs;
    using SongsBackup.Interfaces;

    public class BlobService : IBlobService
    {
        private readonly IConfiguration configuration;
        private readonly BlobServiceClient blobServiceClient;
        private readonly string blobContainerName = "songs-backup";
        
        public BlobService(IConfiguration configuration)
        {
            this.configuration = configuration;
            var blobConnection = this.configuration.GetConnectionString("AzureBlobStorage");

            this.blobServiceClient = new (blobConnection);
        }
        
        public async Task<string> UploadFilesAsync(IFormFile file)
        {
            var blobContainerClient = this.blobServiceClient.GetBlobContainerClient(this.blobContainerName);
            await blobContainerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);
            var blobClient = blobContainerClient.GetBlobClient(file.FileName);
            using (var stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, new BlobHttpHeaders { ContentType = file.ContentType });
            }
            return blobClient.Uri.ToString();
        }
    }
}