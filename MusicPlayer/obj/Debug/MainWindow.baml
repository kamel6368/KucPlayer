   M S B A M L   `   `   `  ����F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MusicPlayer.UserControlsMusicPlayer.UserControls  5   	   )clr-namespace:MusicPlayerMusicPlayer  5   	       MusicPlayer.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;controls&clr-namespace:MusicPlayer.UserControls     5   	   +localclr-namespace:MusicPlayer     5   	     � Title$  
MainWindow��5	   	   $	��500��6   $	��800��6)    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$" local:CustomCommands.AddSong��5      5      .��5   
   �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $��30��6,   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5"   
   ,   &MusicPlayer.UserControls.PlayerControl  $��0��6!   $��0��61   $��3��6>   $��1��6R   0   *MusicPlayer.UserControls.NavigationControl  5$   
   $��0��6%   $��1��65   $��1��6B   $��1��6V   �� 5&   
   $��Right=�6   $��Stretch=�5'      $��1��5(      $��1��5)      $��1��5*      $��1��5+       �� ResizeBehavior$ CurrentAndNext=�5,      
����+��$��5��5.      �� 50   
   $��2��6>   $��1��6N   $��1��6[   $��1��6o   $
��Left=�6�   $	��Top=�6�   ��6   ��  �� Path$ MainContent�6�   53      54      