using System;

using Avalonia;
using Avalonia.Controls;
//using Avalonia.Logging.Serilog;
using Avalonia.Markup.Xaml;

namespace Encore
{
	public class App : Application
	{
		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		private static void Main(string[] args)
		{
			AppBuilder.Configure<App>()
				.UsePlatformDetect()
				.Start<MainWindow>();
		}
	}
}
