   M S B A M L   `   `   `  ����D  @ELjournal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ELjournal.WindowsELjournal.Windows  5   	       ELjournal.Windows.MarkWin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ELjournal.Windows     5   	   -   5         	  winSt#��[  5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ EditStudent��5   	    � 
ResizeMode$ NoResize=�5   	   $	��500��5   	    � SizeToContent$ WidthAndHeight=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$
 Exit��5      $��15��5      $	��5.6(�5      $��X��5      $��15��5      $
��Left=�5      $	��Top=�5      $��2q�5      �� 5   
   $%��Поставить оценку��6   $��20q�5      $��30(�5       �� 5!   
   $��1��6   .+�5#      �� $��Группа��6   $��	 0 15 0 0q�5$      $��20(�5%        tbStyle#��[ 5&      $��Center=�5'      �� 5(      -   5         ��Name$ edGroup��5(      $	��200��5)      $��14(�5*      5+      �� 5-      -   5         ��Name$ spStud��5-      $y�	Collapsed=�5.      .+�50      �� -   5        	 ��Name$	 tblStud��52      $��Студент��50      $��	 0 15 0 0q�51      $��20(�53      #��[ 54      $��Center=�55      �� 56      -   5        $ cbStud��56      $	��200��57      $��14(�58      59      5:      �� 5<      -   5        $ spMrk��5<      $y�	Collapsed=�5=      .+�5>      �� -   5        $	 tblMark��5@      $��Оценка��5>      $��	 0 15 0 0q�5?      $��20(�5A      #��[ 5B      $��Center=�5C      �� 5D      -	   5        $ cbMark��5D      $	��200��5E      $��14(�5F      5G      �� 5H      -
   5        
 ��Name$	
 tbx��5H      $��	 0 15 0 0q�5I      $��Комментарий��5J      $
��auto��5K      $	��150��5L       �� TextWrapping$
 Wrap=�5M      5O      �� 5R      -   5        $ saveCh��5R      $��Добавить��5S      $��25��5T      $	��100��5U      $��10q�5V       �� 	IsDefault . 5X      5Z      5[      5\      