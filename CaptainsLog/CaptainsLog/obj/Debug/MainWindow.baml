   M S B A M L   `   `   `  ����F  BCaptainsLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CaptainsLogCaptainsLog  5   	       CaptainsLog.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CaptainsLog     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridLogEntries��5
      $
��Left=�6+   $��
248,22,0,0q�6F   $	��Top=�6Z   $	��199��6r   $	��259��6      SelectionMode$ Extended=�6�      SelectionUnit$ FullRow=�6�   6�   �� 5   
   -   5         ��Name$ button��5      $��Publish��6!   $
��Left=�63   $��	10,54,0,0q�6N   $	��Top=�6a   $	��102��6y   $��27��6�   6�   �� 5   
   -   5         ��Name$ textBox_Title��5      $
��Left=�6)   $��27��6D   $��	10,22,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��233��6�   �� 5   
   -   5         ��Name$ label_Title��5      $��Title��6%   $
��Left=�65   $��24��6P   $��10,0,0,0q�6\   $	��Top=�6n   $	��120��6�   �� 5   
   -   5        $ textBox_Entry��5      $
��Left=�6)   $	��192��6D   $��
10,104,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6z   $	��233��6�   �� 5   
   -   5        $ label_Entry��5      $��Entry:��6%   $
��Left=�66   $��	10,78,0,0q�6Q   $	��Top=�6d   $��73��6|    J� RenderTransformOrigin$ 0.535,0.948&�6�   �� 5   
   -   5        $ button_Clear��5      $��Clear��6'   $
��Left=�67   $��
131,54,0,0q�6R   $	��Top=�6f   $	��112��6~   $��27��6�   �� 5   
   -   5        $ button_Delete��5      $��Delete��6(   $
��Left=�69   $��405,277,0,0q�6T   $	��Top=�6i   $��76��6�   $��27��6�   �� 5   
   -	   5        $ idSelect��5      $
��Left=�6$   $��38��6?   $��387,234,0,0q�6K   $
 Wrap=�6`   $��TextBox��6t   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -
   5        $ label��5      $��Journal ID:��6   $
��Left=�65   $��312,234,0,0q�6P   $	��Top=�6e   $��75��6}   $��38��6�   5      5      