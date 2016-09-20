using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using MusicPlayer.ViewModels;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.Converters
{
  public class NavigationPlaylistsBoolToVisibilityConverter : IValueConverter
  {
    private INavigationViewModel _navigationViewModel;

    public NavigationPlaylistsBoolToVisibilityConverter()
    {
      _navigationViewModel = IocKernel.IocKernel.Get<INavigationViewModel>();
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return _navigationViewModel.IsPlaylistsListVisible ? Visibility.Visible : Visibility.Hidden;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return null;
    }
  }
}