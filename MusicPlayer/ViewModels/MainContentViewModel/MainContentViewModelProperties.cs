using System.Windows.Controls;

namespace MusicPlayer.ViewModels
{
  public partial class MainContentViewModel
  {
    public UserControl MainContent
    {
      get { return _userControl; }
      set
      {
        _userControl = value;
        RaisePropertyChanged("MainContent");
      }
    }
  }
}