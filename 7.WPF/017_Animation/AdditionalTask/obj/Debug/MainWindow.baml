   M S B A M L   `   `   `  ����I  EAdditionalTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AdditionalTaskAdditionalTask  5   	       AdditionalTask.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AdditionalTask     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � Triggers 5	      :� 5
   
    :� 
SourceName$ cmdStart��6    :� RoutedEvent$ Button.Click��6-   .[�5      �� -   5         ��Name$ fadeStoryboardBegin��5      .��5      �� -   5         g�Name$ fadeStoryboard��5      .��5      W�  �� 
TargetName$ square��6&    �� TargetProperty$ Opacity�5   &    W� From$ 1X�5   &   		 W� To$	 0X�6/   
 g� Duration$
 0:0:5D�66   5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   �� $��
Circle.png��6   6&   �� 5   
   -   5        $��square��5   $   $��
Square.png��6   64   �� 5   
   -   5        $��cmdStart��5      $��1��6!   $��20(�6.   $	��150��6<   $��5q�6H   .��6S   Next6Y   5       5!      