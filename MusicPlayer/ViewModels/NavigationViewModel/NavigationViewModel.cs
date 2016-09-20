using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MusicPlayer.Core.Models;
using MusicPlayer.Core.SongFilesManager;
using MusicPlayer.Core.SongFilesManager.Interfaces;
using MusicPlayer.Microsoft;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.ViewModels
{
  public partial class NavigationViewModel : ViewModelBase, INavigationViewModel
  {
    private readonly IPlaylistFilesManager _playlistFilesManager;

    public NavigationViewModel(IMainContentViewModel mainContentViewModel, IPlaylistFilesManager playlistFilesManager)
    {
      SongsCommand = new RelayCommand(mainContentViewModel.ShowSongs);
      AlbumsCommand = new RelayCommand(mainContentViewModel.ShowAlbums);
      ArtistsCommand = new RelayCommand(mainContentViewModel.ShowArtists);

      PlaylistShowHide = new RelayCommand(ShowHidePlaylist);
      AddPlaylistCommand = new RelayCommand(AddNewPlaylist);

      IsPlaylistsListVisible = true;
      _playlistFilesManager = playlistFilesManager;
      UpdatePlaylists();
    }

    public void UpdatePlaylists()
    {
      Playlists = _playlistFilesManager.ReadSongsFromFile();
      RaisePropertyChanged("PlaylistNames");
    }

    private void ShowHidePlaylist()
    {
      IsPlaylistsListVisible = !IsPlaylistsListVisible;
      RaisePropertyChanged("IsPlaylistsListVisible");
    }

    private void AddNewPlaylist()
    {
      _playlistFilesManager.SaveNewPlaylist();
      UpdatePlaylists();
    }
  }
}