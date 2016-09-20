using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using MusicPlayer.Core.Players.Interfaces;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.Converters
{
  public class PlayerPauseBoolToVisibilityConverter : IValueConverter
  {
    private readonly IPlayerViewModel _playerViewModel;

    public PlayerPauseBoolToVisibilityConverter()
    {
     _playerViewModel = IocKernel.IocKernel.Get<IPlayerViewModel>();
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return _playerViewModel.IsPlaying ? Visibility.Visible : Visibility.Hidden;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return null;
    }
  }
}