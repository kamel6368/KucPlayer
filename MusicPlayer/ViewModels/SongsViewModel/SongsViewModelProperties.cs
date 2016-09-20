using System.Collections.Generic;
using System.Windows.Input;
using MusicPlayer.Core.Models;

namespace MusicPlayer.ViewModels
{
  public partial class SongsViewModel
  {
    public ICommand SortTitleCommand { get; private set; }

    public ICommand SortAlbumCommand { get; private set; }

    public ICommand SortArtistCommand { get; private set; }

    public ICommand SortDurationCommand { get; private set; }

    public List<Song> Songs { get; private set; }
  }
}