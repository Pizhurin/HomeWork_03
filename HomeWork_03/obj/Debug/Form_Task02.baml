   M S B A M L   `   `   `  ����F  BHomeWork_03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HomeWork_03HomeWork_03  5   	       HomeWork_03.Form_Task02   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HomeWork_03     5   	   -   5          �Name$  Task02��5   	    � Title$ Task 02��5   	   $	��450��5	   	   $	��800��5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � -   5         �Name$ mainGrid��5      
������� J� 	AllowDrop .  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      �� 5      $��30 �6   .+�5   
   o� -   5         o�Name$ Task02_menu��5      $��20��6$   $	��Top=�60   $��0��6H    K� ZIndex$ 1��6U   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ userGrid_clearImage��5      $'��!Очистить картинки��68   6S   m� 5      -   5        $ userGrid_changeImage��5      $+��%Перемешать картинки��69   6V   5      5      � 5   
   -   5        $ userGrid��5      
������� . $ 1��6D   $��1��6U   5       �� 5#   
   $+��%Количество столбцов��6   $
��Left=�6.   $��0 0 0 0q�6I   $��2��6Z   $��Center=�6g   �� 5$   
   -   5        	 ��Name$ 	 textBox_Task02_columnCount��5$      $
��Left=�66   $��23��6Q   $��	130 0 0 0q�6]   $��2��6p   $��0��6}   $��Center=�6�   $��50��6�   �� 5%   
   $%��Количество строк��6   $
��Left=�6+   $��	200 0 0 0q�6F   $��2��6Y   $��Center=�6f   �� 5&   
   -   5        $	 textBox_Task02_rowsCount��5&      $
��Left=�65   $��23��6P   $��	320 0 0 0q�6\   $��2��6o   $��0��6|   $��Center=�6�   $��50��6�   �� 5'   
   -	   5        
 ��Name$
 btn_Task02_buildNewGrid��5'      $��Задать сетку��62   $
��Left=�6I   $��	400 0 0 0q�6e   $��2��6x   $��Center=�6�   $	��100��6�   6�   �� 5(   
   -
   5         ��Name$ l1��5(      $��l1��6   $��	600 0 0 0q�6)   $��50��6<   $
��Left=�6G   $��2��6b   �� 5)   
   -   5        $ l2��5)      $��l1��6   $��	650 0 0 0q�6)   $��50��6<   $
��Left=�6G   $��2��6b   5-      5.      