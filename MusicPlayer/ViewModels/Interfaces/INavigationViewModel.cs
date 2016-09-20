using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Input;
using MusicPlayer.Core.Models;

namespace MusicPlayer.ViewModels.Interfaces
{
  public interface INavigationViewModel
  {
    ICommand SongsCommand { get; }
    ICommand PlaylistsCommand { get; }
    ICommand AlbumsCommand { get; }
    ICommand ArtistsCommand { get; }

    ICommand PlaylistShowHide { get; }
    ICommand AddPlaylistCommand { get; }

    bool IsPlaylistsListVisible { get; }
    List<Playlist> Playlists { get; }
    void UpdatePlaylists();

    void PlaylistsListBox_OnMouseDoubleClick(object sender, MouseButtonEventArgs e);
    void PlaylistsListBox_OnDrop(object sender, DragEventArgs e);
    void PlaylistsListBox_OnDragEnter(object sender, DragEventArgs e);
  }
}