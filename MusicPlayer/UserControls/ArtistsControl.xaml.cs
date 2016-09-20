using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MusicPlayer.ViewModels.Interfaces;

namespace MusicPlayer.UserControls
{
  public partial class ArtistsControl : UserControl
  {
    public ArtistsControl()
    {
      InitializeComponent();
      DataContext = IocKernel.IocKernel.Get<IArtistsViewModel>();
    }
  }
}
