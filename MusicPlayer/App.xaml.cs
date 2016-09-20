using System.Windows;
using MusicPlayer.Core.Modules;
using MusicPlayer.Modules;
using MusicPlayer.ViewModels;
using Ninject;

namespace MusicPlayer
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);
      ConfigureKernel();
      ComposeObjects();
      Current.MainWindow.Show();
    }

    private void ConfigureKernel()
    {
      IocKernel.IocKernel.Initialize(new DefaultModule(), new ViewControlModule());
    }

    private void ComposeObjects()
    {
      Current.MainWindow = IocKernel.IocKernel.Get<MainWindow>();
    }
  }
}
