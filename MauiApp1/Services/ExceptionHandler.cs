using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public interface IExceptionHandler
    {
        void HandleException(Exception ex);
    }

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
}
