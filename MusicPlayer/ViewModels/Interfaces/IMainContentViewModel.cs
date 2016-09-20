using System.Data;
using System.Windows.Controls;
using System.Windows.Input;
using MusicPlayer.Core.Models;

namespace MusicPlayer.ViewModels.Interfaces
{
  public interface IMainContentViewModel
  {
    UserControl MainContent { get; set; }
    void ShowSongs();
    void ShowPlaylist(Playlist playlist);
    void ShowAlbums();
    void ShowArtists();
  }
}