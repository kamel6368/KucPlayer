using Ninject.Modules;
using Ninject.Extensions.Conventions;

namespace MusicPlayer.Core.Modules
{
  public class DefaultModule : NinjectModule
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