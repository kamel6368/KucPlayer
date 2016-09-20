using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MusicPlayer.Core.Models;
using MusicPlayer.MenuCommands.Interfaces;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.UserControls
{
  public partial class NavigationControl : UserControl
  {
    public NavigationControl()
    {
      InitializeComponent();
      DataContext = IocKernel.IocKernel.Get<INavigationViewModel>();
    }

    private void PlaylistsListBox_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    { 
      ((INavigationViewModel)DataContext).PlaylistsListBox_OnMouseDoubleClick(sender, e);
    }

    private void PlaylistsListBox_OnDrop(object sender, DragEventArgs e)
    {
      ((INavigationViewModel)DataContext).PlaylistsListBox_OnDrop(sender, e);
    }

    private void PlaylistsListBox_OnDragEnter(object sender, DragEventArgs e)
    {
      ((INavigationViewModel)DataContext).PlaylistsListBox_OnDragEnter(sender, e);
    }
  }
}
