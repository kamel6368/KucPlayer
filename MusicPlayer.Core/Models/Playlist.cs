using System.Collections.Generic;

namespace MusicPlayer.Core.Models
{
  public class Playlist
  {
    public string Name { get; set; }
    public List<Song> List { get; set; }
  }
}