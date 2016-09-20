using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MusicPlayer.Core.Models;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.ViewModels
{
  public partial class SongsViewModel
  {
    private Point startMousePosition;

    public void SongsListItem_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
     
    }

    public void SongsList_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      startMousePosition = e.GetPosition(null);
    }

    public void SongsList_OnPreviewMouseMove(object sender, MouseEventArgs e)
    {
      Point currentMousePosition = e.GetPosition(null);
      Vector diff = startMousePosition - currentMousePosition;
      if (e.LeftButton == MouseButtonState.Pressed &&
          Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance &&
          Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
      {
        ListView listView = sender as ListView;
        var selectedSongs = listView.SelectedItems;
        DataObject dragData = new DataObject("SongFormat", selectedSongs);
        DragDrop.DoDragDrop(listView, dragData, DragDropEffects.Move);
      }
    }
  }
}