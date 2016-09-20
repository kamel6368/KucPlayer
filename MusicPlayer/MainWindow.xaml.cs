using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using MusicPlayer.Core.Models;
using MusicPlayer.Core.SongFilesManager.Interfaces;
using MusicPlayer.MenuCommands.Interfaces;
using MusicPlayer.UserControls;
using MusicPlayer.ViewModels;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer
{
  public partial class MainWindow : Window
  {
    private readonly IAddSongCommand _addSongCommand;

    public MainWindow(IAddSongCommand addSongCommand)
    {
      _addSongCommand = addSongCommand;
      InitializeComponent();
      DataContext = IocKernel.IocKernel.Get<IMainContentViewModel>();
    }

    private void CommandBinding_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      _addSongCommand.CanExecute(sender, e);
    }

    private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
      _addSongCommand.Executed(sender, e);
      ((IMainContentViewModel)DataContext).ShowSongs();
    }
  }

  public static class CustomCommands
  {
    public static readonly RoutedUICommand AddSong = new RoutedUICommand
      ("AddSong", "AddSong", typeof(CustomCommands), new InputGestureCollection());
  }
}
