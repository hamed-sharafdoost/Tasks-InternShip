   M S B A M L   `   `   `  ����E  AVDap.Task7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VDap.Task7.ViewVDap.Task7.View  5           VDap.Task7.View.AddNewGame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VDap.Task7.View     5      .��5	      �   � 	Resources  5
   
    �� 
TargetType   
LabelStyle �� Property �� Value  TextBoxStyle �� Triggers P� Property P� Value��%�   &	        &	 H     �� 5      " ��6   .�5      ��  � ��$ 20(�6-   5      �� 5      " ��6    5      P� 5       �@J�	IsFocused . . �5      ��  � ��
 �����6G   5      5      5       � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      $��* �6   6+   .+�5   
   �� #��[  6   $
��Name��64   6E   �� 5    
   #��[ 6   $��20(�68   $��1��6F   $��10,10q�6V   ��6e   �� *Name+	 �� UpdateSourceTrigger$	 	LostFocus=�6�   �� 5!   
   #��[  6   $��1��64   $��Description��6A   6Y   �� 5"   
   #��[ 6   $��20(�68   $��1��6F   $��1��6S   $��10,10q�6c   ��6r   �� *Description+$	 	LostFocus=�6�   �� 5#   
   $��20(�6   $��2��6   $��5q�6,   $��Add new Game��68   $��30,10q�6O   ��6^   �� *
AddCommand+6   �� 5$   
   $��20(�6   
���  ��$��1��6m   $��2��6}   $
��Auto��6�   $��10q�6�   ��6/   �� *Label+$	 PropertyChanged=�6�   5%      5&      