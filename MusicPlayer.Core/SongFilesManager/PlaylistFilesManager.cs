using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using MusicPlayer.Core.Models;
using MusicPlayer.Core.SongFilesManager.Interfaces;
using Newtonsoft.Json;

namespace MusicPlayer.Core.SongFilesManager
{
  public class PlaylistFilesManager : IPlaylistFilesManager
  {

    private string _path = "playlists.xxx";

    public PlaylistFilesManager()
    {
      CreateFileIfDoesNotExists();
    }

    public List<Playlist> ReadSongsFromFile()
    {
      List<Playlist> jsonResult = JsonConvert.DeserializeObject<List<Playlist>>(File.ReadAllText(_path));
      return jsonResult ?? new List<Playlist>();
    }

    public void SaveNewPlaylist()
    {
      List<Playlist> allPlaylists = ReadSongsFromFile();
      string newPlaylistName = "NewPlaylist0";
      int counter = 0;
      while (allPlaylists.Any(l => l.Name.Equals(newPlaylistName)))
      {
        newPlaylistName = newPlaylistName.Substring(0, newPlaylistName.Length - 1) + (++counter);
      }
      allPlaylists.Add(new Playlist()
      {
        Name = newPlaylistName,
        List = new List<Song>()
      });
      File.WriteAllText(_path, JsonConvert.SerializeObject(allPlaylists));
    }

    public void UpdatePlaylistName(string oldName, string newName)
    {
      string jsonString = File.ReadAllText(_path);
      jsonString = jsonString.Replace("\"Name\":\"" + oldName + "\"", "\"Name\":\"" + newName + "\"");
      File.WriteAllText(_path, jsonString);
    }

    private void CreateFileIfDoesNotExists()
    {
      if (!File.Exists(_path))
      {
        File.Create(_path);
      }
    }
  }
}