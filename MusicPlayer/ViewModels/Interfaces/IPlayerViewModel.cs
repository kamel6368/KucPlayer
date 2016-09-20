using System;
using System.Collections.Generic;
using System.Windows.Input;
using MusicPlayer.Core.Models;

namespace MusicPlayer.ViewModels.Interfaces
{
  public delegate void StartPlaying(double durationSeconds);

  public interface IPlayerViewModel
  {
    ICommand PlayCommand { get; }
    ICommand PauseCommand { get; }
    ICommand NextCommand { get; }
    ICommand PreviousCommand { get; }

    string CurrentTimeStamp { get; }

    double CurrentTimeSeconds { get; set; }
    double NaturalDurationSeconds { get; }

    bool IsPlaying { get; }
    
    double CurrentVolume { get; set; }
  }
}