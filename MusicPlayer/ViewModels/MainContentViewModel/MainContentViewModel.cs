using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.SqlServer.Server;
using MusicPlayer.Core.Models;
using MusicPlayer.Microsoft;
using MusicPlayer.UserControls;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.ViewModels
{
  public partial class MainContentViewModel : ViewModelBase, IMainContentViewModel
  {
    private readonly ISongsViewModel _songsViewModel;

    private readonly IPlaylistsViewModel _playlistsViewModel;

    private UserControl _userControl;

    public UserControl MainContent
    {
      get { return _userControl; }
      set
      {
        _userControl = value;
        RaisePropertyChanged("MainContent");
      }
    }

    public MainContentViewModel(ISongsViewModel songsViewModel)
    {
      _songsViewModel = songsViewModel;
      ShowArtists();
    }

    public void ShowSongs()
    {
      MainContent = new SongsControl();
      _songsViewModel.UpdateAllSongsList();
    }

    public void ShowPlaylist(Playlist playlist)
    {
      MainContent = new PlaylistsControl();
      _songsViewModel.UpdatePlaylistSongs(playlist);
    }

    public void ShowAlbums()
    {
      MainContent = new AlbumsControl();
    }

    public void ShowArtists()
    {
      MainContent = new ArtistsControl();
    }
  }
}