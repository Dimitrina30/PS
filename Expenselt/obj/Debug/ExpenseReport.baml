   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5   	       Expenselt.ExpenseReport   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Expenselt     5   	     � Title$  ExpenseIt - Home��5   	   $	��450��6"   $	��800��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   ��5   
   �� 5       �� ImageSource$ watermark.png��6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��Expense Report For:��6   $��20(�5      $
��Bold"�5      ���	#FF000172$��0��5      �� 5      $��Name:��6   $��16(�5      $
��Bold"�5      ���	#FF000172$��1��5!      �� 5"      $��1��6   $
��Left=�5$      $��Center=�5%      $��58,0,0,0q�5&      ��5#      ��  �� Path$
 Name�5&      �� 5'      $��Department:��6   $��16(�5(      $
��Bold"�5)      ���	#FF000172$��2��5+      �� 5,      $��1��6   $
��Left=�5.      $��Center=�5/      $��
107,31,0,0q�50      $��2��51      ��5-      �� $ 
Department�51      � 52      $��3��6    53      �� 54      $��* �6'   �� 55      $��* �6'    57      �� 58      $
��Auto �6$   �� 59      $��* �6$   .+�5<      &   System.Windows.Controls.DataGrid  $��0��6   $��0��5=      $��2��5>         AutoGenerateColumns .     RowHeaderWidth$ 0Q�5A      $��2��5B         
IsReadOnly . ��5?      �� $ Expenses�   Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Expense Type��6.   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5G   .   �� $ ExpenseType�  5H      $	 Amount��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6=   
 5I   -   �� $ ExpenseAmount�5K      5L      5N      5O      5P      