using Ninject.Modules;
using Ninject.Extensions.Conventions;

namespace MusicPlayer.Modules
{
  public class ViewControlModule : NinjectModule
  {
    public override void Load()
    {
      Kernel.Bind(x => x
                        .FromThisAssembly()
                        .SelectAllClasses()
                        .BindDefaultInterfaces()
                        .Configure(c => c.InSingletonScope()));
    }
  }
}