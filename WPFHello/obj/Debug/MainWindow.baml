   M S B A M L   `   `   `  ����C  ?WPFHello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFHelloWPFHello  5   	       WPFHello.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFHello     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ mainGrid��5	       � ColumnDefinitions 5
   
   �� 5      $
��445* �6   �� 5      $
��301* �6   �� 5      $	��54* �6   .+�5   
   �� $��Hello, WPF!��6   $
��Left=�6&   $��	15,10,0,0q�6A   $	��Top=�6T   $��40��6l   $	��177��6x   $��24(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ btnHello��5      $��Hello!��6#   $
��Left=�64   $��142,180,0,0q�6O   $	��Top=�6d   6|   �� 5   
   -   5         ��Name$ lblName��5      $��Name:��6!   $
��Left=�61   $��	15,74,0,0q�6L   $	��Top=�6_   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��	64,78,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   �� 5   
   -   5         ��Name$ gbUser��5      $�� ��6#   $��10,5,87,208q�6-    J� RenderTransformOrigin$ 0.5,0.5&�6B   z�5      V� 5      .~�5      �� �� 5      �� 5      	 �� Angle$	 -0.192Q�6&   T� 5      5      5      �� 5   
   -   5        $ txtName1��5      $
��Left=�6$   $��
64,107,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5   
   -   5        $ txtName2��5      $
��Left=�6$   $��
64,137,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5   
   -   5        $ lblName1��5      $��Name:��6"   $
��Left=�62   $��
15,103,0,0q�6M   $	��Top=�6a   �� 5    
   -	   5        $ lblName2��5       $��Name:��6"   $
��Left=�62   $��
15,134,0,0q�6M   $	��Top=�6a   �� 5!   
   -
   5        
 ��Name$
 peopleListBox��5!      $��1��6)   $��125,0,10,231q�6d   �� 5"   
   -   5        $ btnGreetings��5"      $��	Greetings��6'   $��158,112,51,298q�6;   $��1��6S   6c   5$      5%      