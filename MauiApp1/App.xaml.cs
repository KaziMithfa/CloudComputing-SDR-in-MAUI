using Microsoft.Maui.Controls;
using System.Threading.Tasks;
namespace MauiApp1
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
			Task.Run(async () => await MauiProgram.UploadHelloWorldToAzure());
		}
		protected override void OnStart()
		{
			base.OnStart();

			// You could also call it here if you prefer
			Task.Run(async () => await MauiProgram.UploadHelloWorldToAzure());
		}
	}
}