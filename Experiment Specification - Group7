# ML 23/24-07 Implement ML22/23-8 Implement the SDR representation in the MAUI application with Azure Cloud Integration

## Abstract:

Cloud computing has transformed software development by offering scalable, cost-effective resources accessible over the internet. In this project, we've developed a .NET MAUI application that integrates cloud computing to enhance the generation and storage of Sparse Distributed Representations (SDRs) using Scalable Vector Graphics (SVG) in C#. Users can select a CSV file from their local device for image generation. The application leverages Microsoft Azure for uploading CSV files to a cloud container, where they can be retrieved and processed to generate SDR images. A key feature is the integration of an Azure queue that handles JSON messages, allowing seamless communication between the local device and the cloud. This enables users to trigger the transfer of CSV files from the Azure container to their device or vice versa. Post-generation, images can be securely uploaded to another Azure container. The application demonstrates the benefits of cloud computing, such as scalable storage, efficient resource management, and real-time feedback on actions like file transfers and image processing.

## Introduction:

Cloud computing has become essential in modern software development, offering scalable, on-demand resources that enhance the performance and flexibility of applications. With platforms like Microsoft Azure, developers can offload tasks such as data storage and processing, making applications more efficient and reliable. In this project, we extend a .NET MAUI application originally designed for generating Sparse Distributed Representations (SDRs) using Scalable Vector Graphics (SVG). By integrating with Microsoft Azure, the application now supports cloud-based file management, enabling greater flexibility and scalability. This project demonstrates how combining cloud computing with cross-platform frameworks like .NET MAUI can create powerful, adaptable applications. It also lays the groundwork for future enhancements like real-time data processing, improved security, and optimized performance for larger datasets.

## Requirements:

To develop and run this project in Azure cloud, we need below things and to follow the process step by step.

### Azure Cloud Environment setup:
- [Microsoft Azure Subscription](https://portal.azure.com/#home)
- [Create Azure Resource Groups](https://learn.microsoft.com/en-us/azure/azure-resource-manager/management/manage-resource-groups-portal#create-resource-groups)
- [Create Azure Storage Account](https://learn.microsoft.com/en-us/azure/storage/common/storage-account-create?tabs=azure-portal#create-a-storage-account)
- Azure Storage Connection String: Retrieve it from the Azure Portal under your Storage Account's Access keys in Security + networking.
- Create Blob Storage Folders: In the Azure Portal, go to Containers under your Storage Account, create a new container, and set the desired access level.

### Local Environment setup:
To develop and run this project, we need.
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [.NET Multi-platform App UI workload](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=vswin)

### Development Platform setup:
- Install Visual Studio 2022 via [Visual Studio Installer](https://visualstudio.microsoft.com/downloads/)
- Download and install [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0). The latest version is recommended. 
- Install [.NET Multi-platform App UI workload.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?tabs=vswin&view=net-maui-8.0)
- Build a basic [MAUI Application](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app?view=net-maui-8.0&tabs=vswin&pivots=devices-windows) 
- Add/reference Nuget packages `Microsoft.Maui.Controls`, `Microsoft.Maui.Controls.Compatibility`, `Microsoft.AspNetCore.Components.WebView.Maui`, `Microsoft.Extensions.Logging.Debug`, `Azure.Storage.Blobs`, `Azure.Storage.Queues`, `SkiaSharp` and `Svg.Skia`

### Application setup:
To setup the core application we have to add the corresponding .razor component page, service, and model files one by one.
- Place [NavMenu.razor](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Components/Layout/NavMenu.razor) conponent to navigate the pages.

- Add the corresponding razor pages to operate application action handling.
[ChartConfiguration.razor](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Components/Pages/ChartConfiguration.razor)
[ConfigPage.razor](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Components/Pages/ConfigPage.razor)
[GenerateChart.razor](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Components/Pages/GenerateChart.razor)
[Heatmap.razor](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Components/Pages/Heatmap.razor)
[Home.razor](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Components/Pages/Home.razor)
[ListeningMode.razor](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Components/Pages/ListeningMode.razor)
[UploadCSV.razor](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Components/Pages/UploadCSV.razor)

- To encapsulate related settings add below models.
[ConfigModel.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Models/ConfigModel.cs)
[ConfigurationModel.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Models/ConfigurationModel.cs)
[CsvUploadModel.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Models/CsvUploadModel.cs)

- To inherit core functionalities add below service classes.
[BlobService.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Services/BlobService.cs)
[ConfigService.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Services/ConfigService.cs)
[ConfigurationService.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Services/ConfigurationService.cs)
[CsvDataService.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Services/CsvDataService.cs)
[ExceptionHandler.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Services/ExceptionHandler.cs)
[IPath.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Services/IPath.cs)
[ListeningStateService.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Services/ListeningStateService.cs)
[PathService.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/Services/PathService.cs)

- Add below classess to operate inputes and drive application on listening mood.
[HeatmapInputModel.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/HeatmapInputModel.cs)
[ListeningState.cs](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/MauiApp1/ListeningState.cs)

- Include [MauiProgram](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/saleque143/MauiApp1/MauiProgram.cs) class for service handeling.

# Project Workflow:
![Diagram](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/diagram.png)

# Code demonstration:

## MauiProgram
The provided C# code defines a static class `MauiProgram`, which contains a static method `CreateMauiApp()` responsible for creating a Maui application instance.

```csharp
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
            builder.Services.AddSingleton<ConfigurationService>();
            builder.Services.AddSingleton<BlobService>();
            builder.Services.AddSingleton<IPath, PathService>();
            builder.Services.AddSingleton<IExceptionHandler, ExceptionHandler>();
            builder.Services.AddSingleton<IConfigService, ConfigService>();
            builder.Services.AddSingleton<ListeningStateService>();


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
```

## BlobService Class

This `BlobService` class, is used for uploading files to an Azure Blob Storage container.

### Class Definition

```csharp
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
```

## ConfigService Class

The `ConfigService` class implements the IConfigService interface. It provides concrete methods for saving and loading configuration data using JSON serialization.

### Class Definition

```csharp
public class ConfigService : IConfigService
{
    private readonly string configFilePath = Path.Combine(FileSystem.AppDataDirectory, "config.json");

    public async Task SaveConfigAsync(ConfigModel config)
    {
        var json = JsonSerializer.Serialize(config);
        await File.WriteAllTextAsync(configFilePath, json);
    }

    public async Task<ConfigModel> LoadConfigAsync()
    {
        if (!File.Exists(configFilePath))
            return new ConfigModel();

        var json = await File.ReadAllTextAsync(configFilePath);
        return JsonSerializer.Deserialize<ConfigModel>(json);
    }
}
```

## ConfigurationService Class

The `ConfigurationService` class is responsible for saving configuration data. The implementation details of the storage mechanism are abstracted, allowing flexibility in how and where the configuration is saved (e.g., database, configuration file, etc.).

### Class Definition

```csharp
public class ConfigurationService
{
    public Task SaveConfigurationAsync(ConfigurationModel configurationModel)
    {
        // Implement the logic to save the configuration
        // For example, save to a database or a configuration file
        return Task.CompletedTask;
    }
}
```

## ListeningStateService Class

The `ListeningStateService` class is responsible for managing the state of a listening operation and processing messages from a queue asynchronously.

### Class Definition

```csharp
public class ListeningStateService
{
    public bool IsActive { get; private set; } = false;

    public event Action OnChange;

    public void StartListening()
    {
        IsActive = true;
        NotifyStateChanged();
    }

    public void StopListening()
    {
        IsActive = false;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();

    public async Task ListenToQueueAsync(string connectionString, string queueName, Func<MessageModel, Task> processMessageAsync)
    {
        var queueClient = new QueueClient(connectionString, queueName);

        while (IsActive)
        {
            try
            {
                var messages = await queueClient.ReceiveMessagesAsync(maxMessages: 1, visibilityTimeout: TimeSpan.FromSeconds(30));

                if (messages.Value.Length > 0)
                {
                    var message = messages.Value[0];
                    var messageContent = JsonSerializer.Deserialize<MessageModel>(message.MessageText);

                    await processMessageAsync(messageContent);

                    await queueClient.DeleteMessageAsync(message.MessageId, message.PopReceipt);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
            }

            await Task.Delay(5000); // Adjust polling frequency as needed
        }
    }
}
```

## ExceptionHandler Class

The `ExceptionHandler` class is a concrete implementation of the IExceptionHandler interface. It provides a simple mechanism for logging exceptions to a file.

### Class Definition

```csharp
public class ExceptionHandler : IExceptionHandler
{
    public void HandleException(Exception ex)
    {
        // Log the exception (you can also use other logging mechanisms here)
        var logPath = Path.Combine(FileSystem.AppDataDirectory, "error.log");
        using (var writer = new StreamWriter(logPath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {ex}");
        }
    }
}
```

### MauiProgram

The provided C# code defines a static class `MauiProgram`, which contains a static method `CreateMauiApp()` responsible for creating a Maui application instance.

```csharp
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
    }
}

```

### Input file handeling:

The `CsvDataService` class provides methods for extracting data from CSV files or content. 

- `ReadDataFromCsvAsync`: Reads data from a CSV file asynchronously, constructing a list of hash sets containing integer values. Calculates the maximum and minimum values found in the data.

- `ReadDataFromCsvContent`: Reads data from CSV content synchronously, similar to the asynchronous method but accepts CSV content as a string input. 

Both methods handle parsing errors and ensure the returned data is ready for further processing.

```csharp
namespace MauiApp1.Services
{
    public class CsvDataService
    {
        public async Task<(List<HashSet<int>>, int, int)> ReadDataFromCsvAsync(Stream fileStream)
        {
            try
            {
                var dataSets = new List<HashSet<int>>();
                var allCells = new List<int>();

                // Use StreamReader in asynchronous mode
                using (var reader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        var values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(v => v.Trim())
                                         .Where(v => !string.IsNullOrWhiteSpace(v) && int.TryParse(v, out _))
                                         .Select(int.Parse)
                                         .ToList();

                        if (values.Count > 0)
                        {
                            var cell = new HashSet<int>(values);
                            dataSets.Add(cell);
                            allCells.AddRange(cell);
                        }
                    }
                }
                var maxCell = allCells.Count > 0 ? allCells.Max() + 100 : 0;
                var minCell = allCells.Count > 0 ? allCells.Min() - 100 : 0;
                return (dataSets, maxCell, minCell);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public (List<HashSet<int>>, int, int) ReadDataFromCsvContent(string csvContent)
        {
            var dataSets = new List<HashSet<int>>();
            var allCells = new List<int>();

            // Split the input CSV content by lines
            var lines = csvContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(v => v.Trim())
                                 .Where(v => !string.IsNullOrWhiteSpace(v) && int.TryParse(v, out _))
                                 .Select(int.Parse)
                                 .ToList();

                if (values.Count > 0)
                {
                    var cell = new HashSet<int>(values);
                    dataSets.Add(cell);
                    allCells.AddRange(cell);
                }
            }
            var maxCell = allCells.Count > 0 ? allCells.Max() + 100 : 0;
            var minCell = allCells.Count > 0 ? allCells.Min() - 100 : 0;
            return (dataSets, maxCell, minCell);
        }
    }
}
```

### HeatmapInputModel

The following C# code defines the `HeatmapInputModel` class, which is utilized for managing input related to a heatmap:

```csharp
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

public class HeatmapInputModel
{
    public IBrowserFile CsvFile { get; set; }
    public string CsvContent { get; set; }
    public bool UseFileInput { get; set; } = true;

    [Required(ErrorMessage = "Highlight touch is required.")]
    public int HighlightTouch { get; set; }

    [Required(ErrorMessage = "Figure name is required.")]
    public string FigureName { get; set; }

    [Required(ErrorMessage = "X Axis label is required.")]
    public string XAxisTitle { get; set; }

    [Required(ErrorMessage = "Y Axis label is required.")]
    public string YAxisTitle { get; set; }

    public int? MaxCycles { get; set; }
    public int? MinCell { get; set; }
    public int? MaxCell { get; set; }
    public int? MinTouch { get; set; }
    public int? MaxTouch { get; set; }
    public bool IsHorizontal { get; set; }
}
```

### IPath

The code defines an interface named `IPath` with a single method `GetFolderPath()`, which returns a string representing a folder path. It's part of the `MauiApp1.Services` namespace.

```csharp
namespace MauiApp1.Services
{
    public interface IPath
    {
        string GetFolderPath();
    }
}
```

### PathService

The provided code defines a class named `PathService` within the `MauiApp1.Services` namespace. This class implements the `IPath` interface. The `GetFolderPath()` method of the `PathService` class returns the application data directory path using the `FileSystem.AppDataDirectory` property.

In short:
- The `PathService` class implements the `IPath` interface.
- It has a single method `GetFolderPath()` which returns the application data directory path.

This code is a part of a service that provides functionality related to file paths in a Maui application.

```csharp
namespace MauiApp1.Services
{
    public class PathService : IPath
    {
        public string GetFolderPath()
        {
            return FileSystem.AppDataDirectory;
        }
    }
}
```

### `HandleValidSubmit()` Method Overview

The `HandleValidSubmit()` method is an asynchronous function designed to manage form submissions. Below is a succinct breakdown of its functionality:

- **File Input Handling:**
  - The method first checks if the form utilizes file input (`heatmapInputModel.UseFileInput`) and whether a CSV file is provided (`heatmapInputModel.CsvFile != null`). 
  - If true, it proceeds to read the CSV data from the file using the `CsvDataService.ReadDataFromCsvAsync()` method.

- **Content Input Handling:**
  - If the form does not employ file input and contains CSV content (`!heatmapInputModel.UseFileInput && !string.IsNullOrWhiteSpace(heatmapInputModel.CsvContent)`), it reads the CSV data from the content using `CsvDataService.ReadDataFromCsvContent()` method.

- **Property Assignment:**
  - Following CSV data retrieval, the method sets various properties based on the form input, including `highlightTouch`, `figureName`, `xAxisTitle`, `yAxisTitle`, `isHorizontal`, `numTouches`, and `count`.

This method effectively manages form input, facilitating CSV data retrieval from either a file or content, and subsequent property assignment as per the form input.

```csharp
private async Task HandleValidSubmit()
{
	if (heatmapInputModel.UseFileInput && heatmapInputModel.CsvFile != null)
	{
		var maxFileSize = 1024 * 1024;
		var stream = heatmapInputModel.CsvFile.OpenReadStream(maxFileSize);
		var result = await CsvDataService.ReadDataFromCsvAsync(stream);
		activeCellsColumn = result.Item1;
	}
	else if (!heatmapInputModel.UseFileInput && !string.IsNullOrWhiteSpace(heatmapInputModel.CsvContent))
	{
		var result = CsvDataService.ReadDataFromCsvContent(heatmapInputModel.CsvContent);
		activeCellsColumn = result.Item1;
	}

	highlightTouch = heatmapInputModel.HighlightTouch - 1;
	figureName = heatmapInputModel.FigureName;
	xAxisTitle = heatmapInputModel.XAxisTitle;
	yAxisTitle = heatmapInputModel.YAxisTitle;
	isHorizontal = heatmapInputModel.IsHorizontal;
	numTouches = Math.Min(activeCellsColumn.Count, heatmapInputModel.MaxCycles.HasValue ?
		heatmapInputModel.MaxCycles.Value : 1000);
	count = 0;
```

### `CalculateChartDimensions()` Method Overview

The `CalculateChartDimensions()` method calculates dimensions dynamically for a chart based on the provided data. Here's a concise summary of its functionality:

- **Data Processing:**
  - It iterates through each column of active cells to find the minimum and maximum values (`minCell` and `maxCell`).

- **Chart Dimension Calculation:**
  - Based on whether the chart is horizontal or vertical (`isHorizontal`), it adjusts the chart dimensions accordingly.
  - For horizontal charts, it calculates the chart width and height considering the cell range span and the number of touches.
  - For vertical charts, it calculates the chart height and width similarly.

- **Default Values:**
  - If no active cells are found, it sets default values for `minCell` and `maxCell` to 0.

This method effectively processes the data and determines the appropriate dimensions for the chart based on the provided input.

```csharp
private void CalculateChartDimensions()
{
	minCell = int.MaxValue;
	maxCell = int.MinValue;

	foreach (var column in activeCellsColumn)
	{
		if (column.Any())
		{
			int currentMin = column.Min();
			int currentMax = column.Max();

			if (currentMin < minCell)
				minCell = currentMin;
			if (currentMax > maxCell)
				maxCell = currentMax;
		}
	}

	if (minCell == int.MaxValue && maxCell == int.MinValue)
	{
		minCell = 0;
		maxCell = 0;
	}

	minTouch = 0;
	maxTouch = numTouches;

	if (isHorizontal)
	{
		int cellRangeSpan = activeCellsColumn.Max(col => col.Max()) + 1 - minCell;
		chartWidth = (cellRangeSpan * (cellWidth - 2)) + chartPadding + 200;
		chartHeight = (numTouches * (cellHeight + cellPadding)) + chartPadding + 50;
	}
	else
	{
		int cellRangeSpan = activeCellsColumn.Max(col => col.Max()) + 1 - minCell;
		chartHeight = (cellRangeSpan * (cellHeight - 2)) + chartPadding + 50;
		chartWidth = (numTouches * (cellWidth + cellPadding)) + chartPadding + 200;
	}
}
```

### `GenerateAxisLabelsVertical()` Method Overview

The `GenerateAxisLabelsVertical()` method generates axis labels for a vertical chart. Here's a brief description of its functionality:

- **Range Calculation:**
  - It calculates the range between the minimum and maximum values (`min` and `max`).

- **Step Calculation:**
  - Based on the range, it determines an appropriate step value, considering the magnitude of the range.

- **Label Generation:**
  - It iterates through the range, generating labels at each step.

- **Position Calculation:**
  - For vertical charts (`isVertical`), it calculates the position of each label based on the distance from the minimum value and adjusts it for padding.
  - For horizontal charts, it calculates the position of each label based on the distance from the minimum value.

This method efficiently generates axis labels for vertical charts based on the provided input.

```csharp
private IEnumerable<(string label, int pos)> GenerateAxisLabelsVertical(int min, int max, bool isVertical)
{
	var labels = new List<(string label, int pos)>();
	if (min > 0 && min < 10)
	{
		min = 0;
	}
	int range = max - min;

	int magnitude = (int)Math.Pow(10, (int)Math.Log10(range) - 1);
	int step = (range / magnitude < 5) ? magnitude : magnitude * 5;

	string label;
	int pos;

	for (int i = min; i <= max; i += step)
	{
		label = i.ToString();

		if (isVertical)
		{
			pos = Convert.ToInt32(((float)(i - min) * ((cellHeight - 1) + cellPadding)) + chartPadding) - 12;
		}
		else
		{
			pos = Convert.ToInt32(((float)(i - min) * (cellWidth - 2))) + 100;
		}

		labels.Add((label, pos));
	}
```

### DownloadSVG() and SaveSvgAsImageAsync() Methods

The provided code consists of two methods that work together to asynchronously download an SVG image and save it as a PNG file. Here's the Markdown representation of the code:

```csharp
private async Task DownloadSVG()
{
    //Invoke the JavaScript function to get the SVG content
    var svgContent = await JSRuntime.InvokeAsync<string>("getSvgContent");

    var fileName = "heatmap.png";

    //Convert the SVG content to an image and save it
    await SaveSvgAsImageAsync(svgContent, fileName);

    await DisplayAlert("Download Complete", $"The image has been saved to {fileName}.", "OK");
}

public async Task SaveSvgAsImageAsync(string svgContent, string filename)
{
    //Parse the SVG content
    var svg = new SKSvg();
    svg.FromSvg(svgContent);

    //Create a bitmap to render the SVG onto
    var bitmap = new SKBitmap((int)svg.Picture.CullRect.Width, (int)svg.Picture.CullRect.Height);
    using var canvas = new SKCanvas(bitmap);
    canvas.Clear(SKColors.White);
    canvas.DrawPicture(svg.Picture);
    canvas.Flush();

    //Encode the bitmap as a PNG
    using var image = SKImage.FromBitmap(bitmap);
    using var data = image.Encode(SKEncodedImageFormat.Png, 80);

    //Get the save path
    string folderPath = FileSystem.CacheDirectory;
    string filePath = Path.Combine(folderPath, filename);

    //Write the image data to a file
    using var stream = File.OpenWrite(filePath);
    data.SaveTo(stream);

    await NotifyUser(filePath);
}
```

### User manual to operate the Application intrgate with Azure Cloud.

#### Step 1: At first  the user have to browse the Azure Connection menu and write the required fields. Such as File Container Name means the name of the Blob container where the CSV files will store and Image Container Name means the container where the generated image will store.
![Azure Connection](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/Azure%20Connection%20Establishment.PNG)

#### Step 2: Then the user  will browse the Chart Configuration Menu and write the necessary user defined fields for generating the SDR images.
![Chart Configuration](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/User%20Define%20Chart%20Configuration.PNG)

#### Step 3: User can use the Listening Mode in 2 ways. One is user can give the message locally with required connection string and Image Upload Container (in this case it is the name of the File Container) and then press the start listening button.
![Listening Mode From Local](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/Local%20App%20Listening%20Mode.PNG)

#### Step 4: The next step is to browse the Upload CSV . Here the user will select a CSV file and upload it. By following this steps user can upload as many files as want.
![Upload CSV Files](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/CSV%20Files%20Upload%20To%20The%20Cloud.PNG)

#### Step 5: The last step of the application is the Generate Chart Menu. When the user will click on it all the uploaded files will be available here to select for generating SDR images .As the user will select the files and click Generate image button it will create the image , download it on the background and sends the image to the Image Container file.In this step , the user should stop the listening mode. The user can view this images in the Image Container file. Atlast user need to click on the right top side Red button called `Stop Listening`
![Generate Chart](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/Generate%20Chart.PNG)
![Generate Chart Confirmation](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/After%20SDR%20Generate%20and%20upload%20file%20to%20Cloud.PNG)
![Image File Upload and Save In The Upload Blob Container](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/SDR%20Image%20Saved%20in%20the%20download%20Blob%20Storage.PNG)
![Stop Listening](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/Stop%20Local%20Listening%20Option.PNG)

#### Step 6: The step 3 can be completed by writing a message in the Queue as well. The structure of the message will be like this: 

```json
{
    "Message": "Hey, all files are now in the container; you can start processing.",
    "ConnectionString": "X",
    "ContainerName": "Y"
}
```

#### In the place of X the user have to write the connectionString of his own and in the place of Y the user have to write the Image container Name. Then the user can browse to the Listening Mode and check the Use Existing Configuration and wait for manual upload, as the user is  sending the message from the queue and start listening. The rest of the process is as before from step 4 to step 5.
![Add Message to Azure Queue](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/Add%20Queue%20message%20for%20listening.PNG)
![Listening for Azure Cloud Side](https://github.com/KaziMithfa/CloudComputing-SDR-in-MAUI/blob/main/App%20User%20Manual%20Images/Azure%20Side%20Listening.PNG)

## Conclusion:
This project demonstrates the effective integration of cloud computing with .NET MAUI, utilizing Microsoft Azure to enhance the generation and storage of Sparse Distributed Representations (SDRs) using Scalable Vector Graphics (SVG). By incorporating Azure queue messaging, the application facilitates seamless data transfer between local devices and cloud storage, offering flexibility and control. The project highlights the benefits of cloud integration, including scalable storage, efficient resource management, and real-time feedback. It also lays the groundwork for future improvements, such as enhanced collaboration, stronger security, and better handling of larger datasets.
