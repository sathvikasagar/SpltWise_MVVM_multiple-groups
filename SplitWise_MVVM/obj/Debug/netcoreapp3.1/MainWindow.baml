   M S B A M L   `   `   `  ����I  ESplitWise_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SplitWise_MVVMSplitWise_MVVM  5   	   C&clr-namespace:SplitWise_MVVM.ViewModelSplitWise_MVVM.ViewModel  5   	       SplitWise_MVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SplitWise_MVVM     5   	   <	viewmodel&clr-namespace:SplitWise_MVVM.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
      1   +SplitWise_MVVM.ViewModel.SplitWiseViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � 
�������$��6q�6&    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     5      �� 5      $
��Auto �6#   �� 5      .+�5!      �� $��Name : ��6   $��0��6&   $��0��63   �� 5"      $��0��6   $��1��6#   $��5q�63   ��6>   �� *Name+�� 5#      $��Spent : ��6   $��1��6'   $��0��64   �� 5$      $��1��6   $��1��6#   $��5q�63   ��6?   �� *Spent+�� 5%      $��Share :��6   $��2��6&   $��0��63   �� 5&      $��2��6   $��1��6#   $��5q�63   ��6?   �� *Share+�� 5'      $��3��63   $��1��6@   $��Right=�6P   ��6   �� *	AddPerson+.��6l   
Add Person6x   �� 5(      $��4��63   $��1��6@   $��Right=�6P   ��6   �� *	Calculate+.��6l   Group Calculation6   �� 5)      $��5��66   $��1��6C   $��Right=�6S   ��6   �� *AddNewGroup+.��6o   Add New Group6~   �� 5*      $,��&select any item of group for selection��6   $��6��6F   $��0��6S   5,      &   System.Windows.Controls.DataGrid  5-   
   $��0��6d   $��1��6q   ��6   ��  �� Path$ _person� �� SelectedItem 69   �� $ ItemSelected�5.      5/      50      