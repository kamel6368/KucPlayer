   M S B A M L   `   `   `  ����F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MusicPlayer.ConvertersMusicPlayer.Converters  5      ,    &MusicPlayer.UserControls.PlayerControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;
converters$clr-namespace:MusicPlayer.Converters     5      $	��100��5   3     � 	Resources  5	      @   :MusicPlayer.Converters.PlayerPlayBoolToVisibilityConverter   PlayConverterA   ;MusicPlayer.Converters.PlayerPauseBoolToVisibilityConverter  PauseConverter��%:   &	        &	        5
   
   69     5   
   6:   5      .��5      � .+�5   
   �� $
��Play��6   $
��Left=�6�   $��
214,25,0,0q�6�   $	��Top=�6�   $��50��6�   ��6    ��  �� Path$ PlayCommand�y�6E   �� $ 	IsPlaying� �� 	Converter# [  6�   �� 5   
   $��Pause��6   $
��Left=�6�   $��
214,25,0,0q�6�   $	��Top=�6�   $��50��6�   ��6!   �� $ PauseCommand�y�6G   �� $ 	IsPlaying�# [ 6�   �� 5   
   $
��Left=�6:   $��	10,50,0,0q�6U   $	��Top=�6h   $��79��6�   $��40��6�   ��6   �� $ CurrentTimeStamp�6�   �� 5   
   $
��Left=�66   $��
390,27,0,0q�6Q   $	��Top=�6e   $��83��6}    � Minimum$ 0Q�6�    � Maximum$ 1Q�6�    �� IsMoveToPointEnabled .  � Value 6   �� $ CurrentVolume�6�   �� 5   
   $��Previous��6   $
��Left=�6M   $	��Top=�6h   $��69��6�   $��
127,25,0,0q�6�   ��6$   �� $ PreviousCommand�6�   �� 5   
   $
��Next��6   $
��Left=�6E   $	��Top=�6`   $��69��6x   $��
285,25,0,0q�6�   ��6    �� $ NextCommand�6�   �� 5   
   -   5         ��Name$ 
TimeSlider��5      $��95,59,23,10q�6%   $ 0Q�6d    .  6:   �� $ CurrentTimeSeconds� 6p   �� $ NaturalDurationSeconds�6�   5      5      