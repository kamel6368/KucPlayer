using System.Collections.Generic;
using System.Data;
using System.Windows.Input;
using MusicPlayer.Core.Models;

namespace MusicPlayer.ViewModels.Interfaces
{
  public interface ISongsViewModel
  {
    ICommand SortTitleCommand { get; }
    ICommand SortAlbumCommand { get; }
    ICommand SortArtistCommand { get; }
    ICommand SortDurationCommand { get; }

    List<Song> Songs { get; }
    void PassSongsToPlayer(Song selectedSong);
    void UpdateAllSongsList();
    void UpdatePlaylistSongs(Playlist playlist);
    void PlaySelectedSong();
    int SelectedIndex { get; }

    void SongsListItem_OnMouseDoubleClick(object sender, MouseButtonEventArgs e);
    void SongsList_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e);
    void SongsList_OnPreviewMouseMove(object sender, MouseEventArgs e);
  }
}