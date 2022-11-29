using System;
using System.IO.Pipes;

namespace TestVision.Web.Services
{
	public class BackgroundFolderCheck : BackgroundService
	{
		private readonly ILogger<BackgroundFolderCheck> logger;
		private HttpClient client;
		private FileSystemWatcher watcher;

		public BackgroundFolderCheck(ILogger<BackgroundFolderCheck> logger)
		{
			this.logger = logger;
		}

		protected override Task ExecuteAsync(CancellationToken stoppingToken)
		{
			watcher = new FileSystemWatcher(@"C:\Users\Mateusz_Czwarno\source\repos\zadanie\input");
			watcher.Created += OnCreated;
			watcher.EnableRaisingEvents = true;

			return Task.CompletedTask;
		}
		private void OnCreated(object sender, FileSystemEventArgs e)
		{
			client = new HttpClient();
			client.PostAsync("https://localhost:7050/execute", null);
		}
		
	}
}
