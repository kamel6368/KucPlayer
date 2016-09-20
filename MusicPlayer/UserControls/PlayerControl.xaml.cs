using System.Windows;
using System.Windows.Controls;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.UserControls
{
  public partial class PlayerControl : UserControl
  {
    public double CurrentProgress;

    public PlayerControl()
    {
      InitializeComponent();
      this.DataContext = IocKernel.IocKernel.Get<IPlayerViewModel>();
    }
  }
}
