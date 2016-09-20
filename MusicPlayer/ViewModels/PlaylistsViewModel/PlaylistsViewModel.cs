using MusicPlayer.Core.Models;
using MusicPlayer.Core.SongFilesManager.Interfaces;
using MusicPlayer.Microsoft;
using MusicPlayer.UserControls;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.ViewModels
{
  public partial class PlaylistsViewModel : ViewModelBase, IPlaylistsViewModel
  {
    private IPlaylistFilesManager _playlistFilesManager;

    private INavigationViewModel _navigationViewModel;

    public Playlist CurrentPlaylist { get; set; }

    public string CurrentPlaylistName
    {
      get
      {
        return CurrentPlaylist.Name;
      }
      set
      {
        _playlistFilesManager.UpdatePlaylistName(CurrentPlaylistName, value);
        CurrentPlaylist.Name = value;
        _navigationViewModel.UpdatePlaylists();
        RaisePropertyChanged("CurrentPlaylistName");
      }
    }

    public SongsControl SongsControl { get; }

    public PlaylistsViewModel(IPlaylistFilesManager playlistFilesManager)
    {
      _playlistFilesManager = playlistFilesManager;
      SongsControl = new SongsControl();
    }
  }
}