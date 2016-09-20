using System;
using System.Collections.Generic;
using System.Windows.Input;
using MusicPlayer.Core.Models;
using MusicPlayer.Core.Players.Interfaces;
using MusicPlayer.Core.SongFilesManager.Interfaces;
using MusicPlayer.Microsoft;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.ViewModels
{
  public partial class SongsViewModel : ViewModelBase, ISongsViewModel
  {
    private readonly ISongFilesManager _songFilesManager;

    private readonly IMp3Player _mp3Player;

    public SongsViewModel(ISongFilesManager songFilesManager, IMp3Player mp3Player)
    {
      _songFilesManager = songFilesManager;
      _mp3Player = mp3Player;
      UpdateAllSongsList();
      _mp3Player.OnSongChange += songIndex => { RaisePropertyChanged("SelectedIndex"); };
    }

    public void UpdateAllSongsList()
    {
      Songs = _songFilesManager.ReadSongsFromFile();
    }

    public void UpdatePlaylistSongs(Playlist playlist)
    {
      Songs = playlist.List;
      RaisePropertyChanged("Songs");
    }

    public void PassSongsToPlayer(Song selectedSong)
    {
      List<Song> tempList = new List<Song>();
      tempList.AddRange(Songs);
      tempList.Remove(selectedSong);
      tempList.Insert(0, selectedSong);
      _mp3Player.SongList = tempList;
    }

    public void PlaySelectedSong()
    {
      _mp3Player.Play();
    }

    public int SelectedIndex
    {
      get { return _mp3Player.CurrentSongIndex; }
    }

  }
}