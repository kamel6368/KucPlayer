using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MusicPlayer.Core.Models;

namespace MusicPlayer.ViewModels
{
  public partial class NavigationViewModel
  {
    public ICommand SongsCommand { get; }
    public ICommand PlaylistsCommand { get; }
    public ICommand AlbumsCommand { get; }
    public ICommand ArtistsCommand { get; }

    public ICommand PlaylistShowHide { get; }
    public ICommand AddPlaylistCommand { get; }

    public bool IsPlaylistsListVisible { get; private set; }
    public List<Playlist> Playlists { get; private set; }
    public List<string> PlaylistNames { get { return Playlists.Select(x => x.Name).ToList(); } }
  }
}