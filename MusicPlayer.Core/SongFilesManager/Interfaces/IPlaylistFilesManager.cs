using System.Collections.Generic;
using MusicPlayer.Core.Models;

namespace MusicPlayer.Core.SongFilesManager.Interfaces
{
  public interface IPlaylistFilesManager
  {
    List<Playlist> ReadSongsFromFile();
    void SaveNewPlaylist();
    void UpdatePlaylistName(string oldName, string newName);
  }
}