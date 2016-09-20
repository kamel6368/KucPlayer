using System.Collections.Generic;
using System.Windows.Documents;
using MusicPlayer.Core.Models;

namespace MusicPlayer.Core.SongFilesManager.Interfaces
{
  public interface ISongFilesManager
  {
    List<Song> ReadSongsFromFile();
    void SaveNewSongs(List<Song> newSongs);
  }
}