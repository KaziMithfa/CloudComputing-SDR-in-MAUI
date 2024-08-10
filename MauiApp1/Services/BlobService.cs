using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using System.Threading.Tasks;

public class BlobService
{
    private readonly BlobContainerClient _blobContainerClient;

    public BlobService(string blobServiceEndpoint, string sasToken)
    {
        var blobUri = new Uri($"{blobServiceEndpoint}?{sasToken}");
        _blobContainerClient = new BlobContainerClient(blobUri);
    }

    public async Task UploadFileAsync(string filePath)
    {
        var blobClient = _blobContainerClient.GetBlobClient(Path.GetFileName(filePath));
        await blobClient.UploadAsync(filePath, true);
    }
}
