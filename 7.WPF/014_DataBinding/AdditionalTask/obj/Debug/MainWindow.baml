   M S B A M L   `   `   `  ����I  EAdditionalTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AdditionalTaskAdditionalTask  5   	       AdditionalTask.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AdditionalTask     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   o� $	��Top=�6   $��0��6'   ��64   ��  �� ElementName$ scaleSlider�� �� Path$ Value�.@�5      m� $
��File��6   .@�5      m� $��New Project��6   62   m� 5      $��Open Project��6   63   �� 5      m� 5      $
��Exit��6   6+   5      m� 5      $
��Edit��6   6'   m� 5      $
��View��6   6'   5      �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   $��Center=�69   $��Center=�6V   .+�5      �� ��6   �� $ scaleSlider��$ Value�.��6M   	Message6V   �� 5      -   5        $��messageTextBox��5      ��6,   �� $ scaleSlider��$ Value�6g   �� 5      ��6   �� $ scaleSlider��$ Value�.��6N   Send6T   5      �� 5!   
   -   5        $��scaleSlider��5!      $��2��6$    � Minimum$ 5Q�61    � Maximum$ 50Q�6=    � Value$ 20Q�6J   $��5q�6U   ��6`   ��  �� RelativeSource �� 	 �� Mode$
	 Self=�$ Value�6�   5"      5#      