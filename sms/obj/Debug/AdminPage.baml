   M S B A M L   `   `   `  ����>  :sms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:smssms  5   	       sms.AdminPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:sms     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1024��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�5	   	   .��5
      � -   5        ���	#FFEEEEEE.+�5   
   �� $	��Top=�6   .+�5      � ���	#FF0069C0$��10��6*   � 5      $��5q�6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� $��School Communication��6    $��Center=�6<   $��20(�6W   $��Calibri Light)�5       $
��20 0q�6;   �� 5      $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ FacebookBox=�62   5      �� 5      $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5        $ 
TwitterBox=�62   5      �� 5      $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5        $ 	GithubBox=�62   5      5      �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5!        $ BellOutline=�62   5"      �� 5#      $��30��6   $��30��6(   $��0q�6a   
�������$��0 0 10 0q�5$   /   ��5#   4   Z� ��6J   Z� .��5%        $ Settings=�62   5&      �� 5'      -   5         ��Name$ ButtonPower��5'      $��30��6L   $��30��6W   $��0q�5(   4   
���������5'   c   Z� ��5(      Z� .��5)        $ Power=�62   5*      5+      5,      5-      � 5.   
   $��
250 55 0 0q�6   .+�5/      � -   5         �Name$ MainGrid��5/      $��Center=�6%   $��Center=�6B   51      � 52   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�53      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��53   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 54   2   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+	   Duration$	 0:0:0.2X�.��55      � -   5        $ 
GridCursor��55      $��	0 100 0 0q�6+   ���	#FF0069C0$��10��6U   $
��Left=�56      $��60��62   $	��Top=�6>   57      �� 59      -   5        
 ��Name$
 ListViewMenu��59      $��0 100q�6-   
�������$��0q�6S   $��Champagne & Limousines)�5:      
������ .@�5<      �� $��60��6   .��5=      �� $ 
Horizontal=�6!   .+�5>        $
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�5?   2   �� 5@      $
��Home��6$   $��26(�60   $��Center=�6>   $
��20 0q�6Y   5A      5B      �� 5C      $��60��6   .��5D      �� $ 
Horizontal=�6!   .+�5E        $ 	PersonAdd=�62   $��30��6C   $��30��6N   $��Center=�6Z   $��5q�5F   2   �� 5G      $��Add Student��6$   $��26(�67   $��Center=�6E   $
��20 0q�6`   5H      5I      �� 5J      $��60��6   .��5K      �� $ 
Horizontal=�6!   .+�5L        $ 	PersonAdd=�62   $��30��6C   $��30��6N   $��Center=�6Z   $��5q�5M   2   �� 5N      $��Add Teacher��6$   $��26(�67   $��Center=�6E   $
��20 0q�6`   5O      5P      �� 5Q      $��60��6   .��5R      �� $ 
Horizontal=�6!   .+�5S        $ FormatListBulleted=�62   $��30��6L   $��30��6W   $��Center=�5T   2   $��5q�6M   �� 5U      $��List Student��6$   $��26(�68   $��Center=�6F   $
��20 0q�6a   5V      5W      �� 5X      $��60��6   .��5Y      �� $ 
Horizontal=�6!   .+�5Z        $ FormatListBulleted=�62   $��30��6L   $��30��6W   $��Center=�5[   2   $��5q�6M   �� 5\      $��List Teacher��6$   $��26(�68   $��Center=�6F   $
��20 0q�6a   5]      5^      5`      5a      5b      5c      