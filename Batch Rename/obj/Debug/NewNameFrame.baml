   M S B A M L   `   `   `  ����G  CBatch Rename, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Batch_RenameBatch_Rename  5          Batch_Rename.NewNameFrame   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Batch_Rename     5        N� Title$  NewNameFrame��5	       N� 
Background
 �����.��5      ��  �� Orientation$ Vertical=�6   $
��Left=�6(   $��Center=�6C   $��20q�6`   .+�5   
   �� -   5        $��GuidName��5      $��	GUID Name��6$   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ��  �6C   �� 5       � ��$ 	Underline{�68   �� 5       � ��$ 20(�61    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  � ��
 �  ��6;   5      5      5      �� 5   
   -   5        	 ��Name$	 IncNum��5      $��Incrementing numbers��6$   ��5      �� 5      " ��6   .�5      ��  � ��
 ��  �6C   �� 5       � ��$ 	Underline{�68   �� 5        � ��$ 20(�61    5!      P� 5"       �@J�IsMouseOver . . �5#      ��  � ��
 �  ��6;   5$      5&      5(      �� 5)   
   -   5        $	 	IncLetter��5)      $��Incrementing letters��6'   ��5*      �� 5+      " ��6   .�5,      ��  � ��
 ��  �6C   �� 5-       � ��$ 	Underline{�68   �� 5.       � ��$ 20(�61    5/      P� 50       �@J�IsMouseOver . . �51      ��  � ��
 �  ��6;   52      54      56      �� 57   
   -   5        $	 	Normalize��57      $��	Normalize��6'   ��58      �� 59      " ��6   .�5:      ��  � ��
 ��  �6C   �� 5;       � ��$ 	Underline{�68   �� 5<       � ��$ 20(�61    5=      P� 5>       �@J�IsMouseOver . . �5?      ��  � ��
 �  ��6;   5@      5B      5D      �� 5F   
   -   5        
 ��Name$
 ReturnOldName��5F      $
��Back��6(   
������$��6q�6O   6Z   5H      5I      