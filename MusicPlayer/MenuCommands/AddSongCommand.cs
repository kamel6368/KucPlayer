using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Input;
using Microsoft.Win32;
using MusicPlayer.Core.Models;
using MusicPlayer.Core.Players.Interfaces;
using MusicPlayer.Core.SongFilesManager.Interfaces;
using MusicPlayer.MenuCommands.Interfaces;

namespace MusicPlayer.MenuCommands
{
  public class AddSongCommand : IAddSongCommand
  {
    private readonly ISongFilesManager _songFilesManager = IocKernel.IocKernel.Get<ISongFilesManager>();

    public void CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = true;
    }

    public void Executed(object sender, ExecutedRoutedEventArgs e)
    {
      OpenFileDialog fileDialog = new OpenFileDialog();
      fileDialog.DefaultExt = ".mp3";
      fileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
      if (fileDialog.ShowDialog() == true)
      {
        TagLib.File mp3 = TagLib.File.Create(fileDialog.FileName);
        Song song = new Song()
        {
          Title = mp3.Tag.Title,
          Album = mp3.Tag.Album,
          Artist = mp3.Tag.FirstAlbumArtist,
          DurationSeconds = mp3.Length,
          Uri = new Uri(fileDialog.FileName)
        };

        _songFilesManager.SaveNewSongs(new List<Song>() { song });
      }
    }
  }
}