using System.Windows.Input;

namespace MusicPlayer.MenuCommands.Interfaces
{
  public interface IAddSongCommand
  {
    void CanExecute(object sender, CanExecuteRoutedEventArgs e);
    void Executed(object sender, ExecutedRoutedEventArgs e);
  }
}