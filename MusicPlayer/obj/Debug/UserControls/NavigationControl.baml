   M S B A M L   `   `   `  ����F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MusicPlayer.UserControlsMusicPlayer.UserControls  5      ?$clr-namespace:MusicPlayer.ConvertersMusicPlayer.Converters  5      0    *MusicPlayer.UserControls.NavigationControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:MusicPlayer.UserControls     5      ;
converters$clr-namespace:MusicPlayer.Converters     5        � 	Resources  5      I   CMusicPlayer.Converters.NavigationPlaylistsBoolToVisibilityConverter   PlaylistsConverter��%   &	          5   
   6B   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Songs��6   $��0��6H   ��6!   ��  �� Path$ SongsCommand�6H   �� 5   
   $��Albums��6   $��1��6I   ��6"   �� $ AlbumsCommand�6I   �� 5   
   $��Artists��6   $��2��6K   ��6#   �� $ ArtistsCommand�6K   �� 5   
   $��	Playlists��6   $��3��6O   ��6%   �� $ PlaylistShowHide�6O   �� 5   
   $��4��6   .+�5      �� y�6   �� $ IsPlaylistsListVisible� �� 	Converter# [  .��5      �� -   5        $��PlaylistsListBox��5       �� SelectionMode$ Single=�62    J� 	AllowDrop . ��6I   �� $ PlaylistNames�y�6t   �� $ IsPlaylistsListVisible�# [  5"      5#      �� 5$      $��	+ Add New��6   ��6)   �� $ AddPlaylistCommand�y�6U   �� $ IsPlaylistsListVisible�# [  6�   5%      5'      5(      