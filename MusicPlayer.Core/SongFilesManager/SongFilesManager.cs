using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using Microsoft.Win32;
using MusicPlayer.Core.Models;
using MusicPlayer.Core.SongFilesManager.Interfaces;
using Newtonsoft.Json;

namespace MusicPlayer.Core.SongFilesManager
{
  public class SongFilesManager : ISongFilesManager
  {
    private string _path = "songs.xxx";

    public SongFilesManager()
    {
      CreateFileIfDoesNotExists();
    }

    public List<Song> ReadSongsFromFile()
    {
      List<Song> jsonResult = JsonConvert.DeserializeObject<List<Song>>(File.ReadAllText(_path));
      return jsonResult ?? new List<Song>();
    }

    public void SaveNewSongs(List<Song> newSongs)
    {
      List<Song> allSongs = ReadSongsFromFile();
      allSongs.AddRange(newSongs);
      File.WriteAllText(_path, JsonConvert.SerializeObject(allSongs));
    }

    private void CreateFileIfDoesNotExists()
    {
      if(!File.Exists(_path))
      {
        File.Create(_path);
      }
    }
  }
}