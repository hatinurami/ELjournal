   M S B A M L   `   `   `  ����D  @ELjournal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ELjournal.WindowsELjournal.Windows  5   	   "    ELjournal.Windows.StudentWin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ELjournal.Windows     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    	  winSt#��[  5	   	    � Title$ 
StudentWin��5   	   $	��450��5   	   $	��690��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��84* �6   �� 5      $
��275* �6   �� 5      $	��60* �6   .+�5   
   �� -   5         ��Name$ StudNameLab��5      $%��Студентик группа��5      $��25(�5      $��Center=�5        tbStyle#��[ 5      $��25q�5      $
��Wrap=�5      $��28��6$   �� 5   
   -   5         ��Name$ lbJournalSt��5       $y�Visible=�5!      $��1��5"      
�������$��15q�5$      $��14(�5%       �� View 5'      �� 5(      P�5)      �� 5*      $��Предмет��6)    �� Width$
 auto��5,   )    �� DisplayMemberBinding 5+   *   �� *Subjects.subjName+5,   )   �� 5-      $��Оценка��6)   $
 auto��5/   -    5.   -   �� *mark+5/   -   �� 50      $��Дата��6)   $
 auto��52   -    51   -   �� *dateM+52   -   �� 53      $��Комментарий��6)   $
 auto��55   -    54   -   �� *	comment+55   -   59      5;      � 5>   
   $��2��5?      $��10q�6   .+�5@      �� -   5        	 ��Name$	 btn_Back��5A      $��
Назад��5B      $��50��5C      $
��10 8q�5E      �� 5G      -   5        $	 btn_Next��5H      $��
Далее��5I      $��50��5J      $��10 8 0 8q�5L      �� 5M      $��	100 8 8 8q�5O      #��[ 5P      �� 5R      $A�;Количество записей на странице: ��6   5T      �� 5U      -   5        
 ��Name$
 cb_NumItems��5V      $��1��5W      $��2��5X      $��50��5Y      $��8q�5Z      5]      5_      5�      5�      