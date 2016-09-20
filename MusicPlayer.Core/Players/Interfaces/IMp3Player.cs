using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Markup;
using MusicPlayer.Core.Models;
using Ninject.Extensions.Conventions.BindingGenerators;

namespace MusicPlayer.Core.Players.Interfaces
{
  public delegate void SongTimeStampEvent(string timeStamp);
  public delegate void SongChangeEvent(int songIndex);

  public interface IMp3Player
  {
    event EventHandler OnPlay;
    event EventHandler OnPause;
    event EventHandler OnFileOpened;
    event SongChangeEvent OnSongChange;
    event SongTimeStampEvent OnTick;

    List<Song> SongList { set; }
    string CurrentTimeStamp { get; }
    double CurrentTimeSeconds { get; set; }
    double NaturalDurationSeconds { get; }
    double Volume { get; set; }
    bool IsPlaying { get; }
    int CurrentSongIndex { get; }

    void Play();
    void Pause();
    void Next();
    void Previous();

    bool IsNextSongAvaiable();
    bool IsPreviousSongAvaiable();
    bool CanPlay();
    bool CanPause();

    void AddSongToQueue(Song song);
    void AssignPlaylist(List<Song> playList);
  }
}