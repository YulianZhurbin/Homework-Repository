   M S B A M L   `   `   `  ����I  EAdditionalTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AdditionalTaskAdditionalTask  5   	       AdditionalTask.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AdditionalTask     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      6?     5   
   -   5        $
 Open��5      6A     5   
   -   5        $
 Save��5      6A     5   
   -   5        $ Close��5      6C   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   o� .@�5      m� $
��File��6   .@�5      m�  m� Command$	 New��6   6+   m� 5      $
 Open��6   6,   m� 5      $
 Save��6   6,   �� 5      m� 5      $ Close��6   6-   5      m� 5       $
��Edit��6   .@�5!      m� $	 Cut��6   6+   m� 5"      $
 Copy��6   6,   m� 5#      $ Paste��6   6-   5$      5%      �� 5'   
   -   5        $��textBox��5'      $��1��6!   $��30q�6.   6<   5(      5)      