using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MusicPlayer.Core.Models;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.ViewModels
{
  public partial class NavigationViewModel
  {
    private IMainContentViewModel _mainContentViewModel;

    private IPlaylistsViewModel _playlistsViewModel;

    public void PlaylistsListBox_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      ListBox listBox = sender as ListBox;
      if (listBox != null && listBox.SelectedItems.Count > 0)
      {
        string playlistName = listBox.SelectedItems[0] as string;
        Playlist selectedPlaylist = Playlists.First(x => x.Name.Equals(playlistName));
        _mainContentViewModel.ShowPlaylist(selectedPlaylist);
        _playlistsViewModel.CurrentPlaylist = selectedPlaylist;
      }
    }

    public void PlaylistsListBox_OnDrop(object sender, DragEventArgs e)
    {
      ListBox listBox = sender as ListBox;
    }

    public void PlaylistsListBox_OnDragEnter(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent("SongFormat"))
      {
        e.Effects = DragDropEffects.None;
      }
    }
  }
}