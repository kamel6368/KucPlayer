using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Windows.Input;
using System.Windows.Markup;
using MusicPlayer.Core.Models;
using MusicPlayer.Core.Players.Interfaces;
using MusicPlayer.Microsoft;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.ViewModels
{
  public partial class PlayerViewModel : ViewModelBase, IPlayerViewModel
  {
    private readonly IMp3Player _mp3Player;

    public ICommand PlayCommand { get; internal set; }
    public ICommand PauseCommand { get; internal set; }
    public ICommand NextCommand { get; internal set; }
    public ICommand PreviousCommand { get; internal set; }

    public string CurrentTimeStamp
    {
      get { return _mp3Player.CurrentTimeStamp;  }
    }

    public double CurrentVolume
    {
      get { return _mp3Player.Volume; }
      set
      {
        _mp3Player.Volume = value;
        RaisePropertyChanged("CurrentVolume");
      }
    }

    public double CurrentTimeSeconds
    {
      get { return _mp3Player.CurrentTimeSeconds; }
      set
      {
        _mp3Player.CurrentTimeSeconds = value;
        RaisePropertyChanged("CurrentTimeSeconds");
        RaisePropertyChanged("CurrentTimeStamp");
      }
    }

    public double NaturalDurationSeconds
    {
      get { return _mp3Player.NaturalDurationSeconds; }
    }

    public bool IsPlaying
    {
      get { return _mp3Player.IsPlaying; }
    }

    public PlayerViewModel(IMp3Player mp3Player)
    {
      _mp3Player = mp3Player;

      _mp3Player.OnPlay += (sender, args) => { RaisePropertyChanged("IsPlaying"); };
      _mp3Player.OnPause += (sender, args) => { RaisePropertyChanged("IsPlaying"); };
      _mp3Player.OnFileOpened += (sender, args) => { RaisePropertyChanged("NaturalDurationSeconds"); };
      _mp3Player.OnTick += timeStamp =>
      {
        RaisePropertyChanged("CurrentTimeStamp"); 
        RaisePropertyChanged("CurrentTimeSeconds");
      };

      PlayCommand = new RelayCommand(_mp3Player.Play, _mp3Player.CanPlay);
      PauseCommand = new RelayCommand(_mp3Player.Pause, _mp3Player.CanPause);
      NextCommand = new RelayCommand(_mp3Player.Next, _mp3Player.IsNextSongAvaiable);
      PreviousCommand = new RelayCommand(_mp3Player.Previous, _mp3Player.IsPreviousSongAvaiable);
    }
  }
}