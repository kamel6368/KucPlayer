using System.Windows.Controls;
using System.Windows.Input;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.UserControls
{
  public partial class SongsControl : UserControl
  {

    public SongsControl()
    {
      InitializeComponent();
      DataContext = IocKernel.IocKernel.Get<ISongsViewModel>();
    }

    private void SongsListItem_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
     ((ISongsViewModel)DataContext).SongsListItem_OnMouseDoubleClick(sender, e);
    }

    private void SongsList_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      ((ISongsViewModel)DataContext).SongsList_OnPreviewMouseLeftButtonDown(sender, e);
    }

    private void SongsList_OnPreviewMouseMove(object sender, MouseEventArgs e)
    {
      ((ISongsViewModel)DataContext).SongsList_OnPreviewMouseMove(sender, e);
    }
  }
}
