   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $��15(�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   .+�5   
   �� $��5q�6    �� Orientation$ 
Horizontal=�6    .+�5      �� $��5q�6   $��Editing mode: ��6#   �� 5      -   5        $��editingMode��5      $��Center=�6*   $��Stretch=�6E   $��0,0,10,0q�6c   5      �� 5   
   -   5        $��	inkCanvas��5      $��1��6%    �� 
Background
 ��·� �� EditingMode 6L   ��  �� ElementName$ editingMode�� �� Path$ SelectedItem�5      �� 5   
   -   5        $��gestureName��5      $��Stretch=�6%   $��Bottom=�6C   $��2��6^   5      5      