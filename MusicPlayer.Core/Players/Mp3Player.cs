using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using MusicPlayer.Core.Models;
using MusicPlayer.Core.Players.Interfaces;

namespace MusicPlayer.Core.Players
{
  public class Mp3Player : IMp3Player
  {
    public event EventHandler OnPlay;
    public event EventHandler OnPause;
    public event EventHandler OnFileOpened;
    public event SongChangeEvent OnSongChange;
    public event SongTimeStampEvent OnTick;

    public bool IsPlaying { get; private set; }

    public List<Song> SongList
    {
      set
      {
        _songsList = value;
        CurrentSong = _songsList.First();
      }
    }

    public double CurrentTimeSeconds
    {
      get { return _mediaPlayer.Position.TotalSeconds; }

      set
      {
        _mediaPlayer.Stop();
        _mediaPlayer.Position = TimeSpan.FromSeconds(value);
        _mediaPlayer.Play();
      }
    }

    public double NaturalDurationSeconds
    {
      get
      {
        if (_mediaPlayer.NaturalDuration.HasTimeSpan)
        {
          return _mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
        }
        return 0;

      }
    }

    public string CurrentTimeStamp
    {
      get { return FormatSongTimeStamp(); }
    }

    public int CurrentSongIndex
    {
      get { return _currentSongIndex; }
    }

    public double Volume
    {
      get { return _mediaPlayer.Volume; }

      set { _mediaPlayer.Volume = value; }
    }

    public void Play()
    {
      _mediaPlayer.Play();
      IsPlaying = true;
      OnPlay(this, new EventArgs());
      _timer.Start();
    }

    public void Pause()
    {
      _mediaPlayer.Pause();
      IsPlaying = false;
      OnPause(this, new EventArgs());
    }

    public void Next()
    {
      _mediaPlayer.Stop();
      CurrentSong = _songsList[++_currentSongIndex];
      if (IsPlaying)
      {
        Play();
      }
      OnSongChange(_currentSongIndex);
    }

    public void Previous()
    {
      _mediaPlayer.Stop();
      CurrentSong = _songsList[--_currentSongIndex];
      if (IsPlaying)
      {
        Play();
      }
      OnSongChange(_currentSongIndex);
    }

    public bool IsNextSongAvaiable()
    {
      return _currentSongIndex < _songsList.Count - 1;
    }

    public bool IsPreviousSongAvaiable()
    {
      return _currentSongIndex > 0;
    }

    public bool CanPlay()
    {
      return !IsPlaying && CurrentSong != null;
    }

    public bool CanPause()
    {
      return IsPlaying;
    }

    public void AddSongToQueue(Song song)
    {
      _songsList.Add(song);
    }

    public void AssignPlaylist(List<Song> playList)
    {
      _songsList = playList;
    }

    private List<Song> _songsList;
    private int _currentSongIndex;
    private readonly MediaPlayer _mediaPlayer;

    private readonly DispatcherTimer _timer;

    public Mp3Player()
    {
      _mediaPlayer = new MediaPlayer();
      _mediaPlayer.MediaEnded += (sender, args) =>
      {
        _timer.Stop();
        if (IsNextSongAvaiable())
        {
         Next(); 
        }        
      };
      _mediaPlayer.MediaOpened += (sender, args) => { OnFileOpened(this, EventArgs.Empty); };

      _songsList = new List<Song>();

      _timer = new DispatcherTimer();
      _timer.IsEnabled = true;
      _timer.Interval = TimeSpan.FromSeconds(1);
      _timer.Tick += (sender, args) =>
      {
        OnTick(FormatSongTimeStamp());
      };
    }

    private string FormatSongTimeStamp()
    {
      if (_mediaPlayer.NaturalDuration.HasTimeSpan)
      {
        return _mediaPlayer.Position.ToString(@"mm\:ss") + " / " + _mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
      }
      return "00:00 / 00:00";
    }

    private Song CurrentSong
    {
      get { return _songsList.Any() ? _songsList[_currentSongIndex] : null; }
      set
      {
        _mediaPlayer.Open(value.Uri);
      }
    }
  }
}