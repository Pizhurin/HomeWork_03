   M S B A M L   `   `   `  ����F  BHomeWork_03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HomeWork_03HomeWork_03  5   	       HomeWork_03.Form_Task01   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HomeWork_03     5   	   -   5          �Name$  Task01��5   	    � Title$ Task 01��5   	   $	��450��5	   	   $	��800��5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � -   5        
������� � ColumnDefinitions 5   
   �� 5      -   5         ��Name$ columnGrid_0��5   ,   $
��550* �6   6,   �� 5      -   5        $ columnGrid_1��5   ,   $
��250* �6   6,   .+�5   
   �� -   5         ��Name$ Image_Task01_image��5      $��PiN.jpg��5      $
��None=�5      $��0��5       J� 	AllowDrop .  K� ZIndex$ 1��5      5   ~   �� 5   
   -   5         ��Name$ Lable_Task01_lable��5      $E��?Перетащите сюда необходимые файлы��5      $��1��5      $��Center=�5       $	��Top=�5!      $
��0 10q�5"      $ 1��5#      �� 5$   
   -   5        	 ��Name$#	 listBox_Task01_filesDragNDrop��5$      $��1��5%      
������� . 5*      �� 5+   
   -   5        $	 lll��5+      $$��Масштабирование��6   $��Center=�68   $��1��6U   $��0 0 0 40q�6e   $��Bottom=�6w   �� 5,   
   -	   5        
 ��Name$
 Slider_Task01_scaleSlider��5,      $��1��5-      $��Bottom=�5.      $��0 0 0 20q�5/      $	��200��6#   $��Center=�50       � Value$ 50Q�51       � Maximum$	 100Q�52      53      58      5:      