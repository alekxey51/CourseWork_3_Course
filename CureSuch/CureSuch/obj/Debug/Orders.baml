   M S B A M L   `   `   `  ����C  ?CureSuch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CureSuchCureSuch  5   	       CureSuch.Orders   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CureSuch     5   	     � Title$  Orders��5   	   $��419.748��6   $��706.975��6)   ��5	      �� 5
   
    �� ImageSource$ wed1.jpg��6   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��30,40,30,64q�6%      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ IdOrder�  5       6%   �� $
 Name�  5       6%   �� $
 Date�  5       6%   �� $ DescryptionShort�  5       6%   �� $ DescryptionLong�  5       6%   �� $ Price�5      �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Ваши заказы:��6C   $	��Top=�6W   $��	30,10,0,0q�6o   $��25��6�   $	��128��6�   $��20(�6�   $��Arial)�6�   
�������6�   �� 5   
   -   5         ��Name$ CureName��5      $
��Left=�6F   $��24��6a   $��412,346,0,0q�6m    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��157��6�   $��17(�6�   
���   �6�   �� 5   
   -   5        $ 
Whatermark��5      $
��Left=�6F   $��24��6a   $��402,346,0,0q�6m   $
 Wrap=�6�   $&�� Введите Id заказа..��6�   $	��Top=�6�   $	��157��6�   $��17(�6�   
�������6�   �� 5   
   -   5         ��Name$ Delete��5      $��Удалить��6"   $
��Left=�64   $��559,346,0,0q�6O   $	��Top=�6d   $��79��6|   $��24��6�   6�   5      5      