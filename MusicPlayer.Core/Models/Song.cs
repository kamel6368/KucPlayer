using System;
using MusicPlayer.Core.Microsoft;

namespace MusicPlayer.Core.Models
{
  public class Song : ModelBase
  {
    private string _title;
    private string _album;
    private string _artist;
    private double _durationSeconds;

    public string Title
    {
      get { return _title; }
      set
      {
        _title = value;
        RaisePropertyChanged("Title");
      }
    }

    public string Album
    {
      get { return _album; }
      set
      {
        _album = value;
        RaisePropertyChanged("Album");
      }
    }

    public string Artist
    {
      get {return _artist; }
      set
      {
        _artist = value;
        RaisePropertyChanged("Artist");
      }
    }

    public double DurationSeconds
    {
      get { return _durationSeconds; }
      set
      {
        _durationSeconds = value;
        RaisePropertyChanged("Value");
      }
    }
    ////todo album cover
    public Uri Uri { get; set; }
  }
}