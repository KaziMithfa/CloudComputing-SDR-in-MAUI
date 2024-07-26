using MauiApp1.Services;
using Microsoft.Extensions.Logging;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<CsvDataService>();
            builder.Services.AddSingleton<IPath, PathService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
        public static async Task UploadHelloWorldToAzure()
{
	try
	{
		// Retrieve the connection string for use with the application. 
		string connectionString = "GitHub is blocking the connection string";

		// Create a BlobServiceClient object 
		var blobServiceClient = new BlobServiceClient(connectionString);

		//Create a unique name for the container
		string containerName = "quickstartblobs" + Guid.NewGuid().ToString();

		// Create the container and return a container client object
		BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);

		// Create a local file in the ./data/ directory for uploading and downloading
		string localPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "data");
		Directory.CreateDirectory(localPath);
		string fileName = "quickstart_" + Guid.NewGuid().ToString() + ".txt";
		string localFilePath = Path.Combine(localPath, fileName);

		// Write text to the file
		await File.WriteAllTextAsync(localFilePath, "Hello, World!");

		// Get a reference to a blob
		BlobClient blobClient = containerClient.GetBlobClient(fileName);

		Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

		// Upload data from the local file, overwrite the blob if it already exists
		await blobClient.UploadAsync(localFilePath, true);

		Console.WriteLine("Listing blobs...");

		// List all blobs in the container
		await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
		{
			Console.WriteLine("\t" + blobItem.Name);
		}

		// Download the blob to a local file
		// Append the string "DOWNLOADED" before the .txt extension 
		// so you can compare the files in the data directory
		string downloadFilePath = localFilePath.Replace(".txt", "DOWNLOADED.txt");

		Console.WriteLine("\nDownloading blob to\n\t{0}\n", downloadFilePath);

		// Download the blob's contents and save it to a file
		await blobClient.DownloadToAsync(downloadFilePath);
	}
	catch (Exception ex)
	{
		Console.WriteLine($"An error occurred: {ex.Message}");
	}
}
    }
}
