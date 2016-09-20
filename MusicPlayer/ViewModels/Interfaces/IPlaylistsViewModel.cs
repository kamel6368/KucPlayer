using MusicPlayer.Core.Models;
using MusicPlayer.UserControls;

namespace MusicPlayer.ViewModels.Interfaces
{
  public interface IPlaylistsViewModel
  {
    Playlist CurrentPlaylist { get; set; }
    string CurrentPlaylistName { get; set; }
    SongsControl SongsControl { get; }
  }
}