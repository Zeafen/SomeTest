   M S B A M L   `   `   `  ����  Project(Ver3.0)#    Project_Ver3._0_.ResultWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  ResultWindow��5   	   $	��585��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�5   Q    � WindowState$ 	Maximized=�6v    � DataContext 6	   �� *	testModel+ �� RelativeSource �� *Self+ � 	Resources 5	      �� 5
   
      KeyTaskSelectionTemplate   �� ResourceKey$ TaskSelection��67   .��5      � -   5        $��ResWin��5   5    � IsSharedSizeScope . $��3,3,3,3q�6$    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      	 � RowDefinitions	 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $	��150 �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        
 ��Name$
 
Conclusion��5   5   $��0��6   $��3��6!   $��10,10,10,10q�6I   $��16(�6^   $��Times New Roman)�6l   $
��Wrap=�6�   �� 5   
   -   5         ��Name$ FirstMistakeslbl��5      $��First text Mistakes��6*   $��0��6H   $y�Hidden=�6X   $��2��6l   $��0,38,264,187q�6�   $��3��6�   �� 5   
   -   5        $��1��5      $��3��6!   
������$��Restart��6F   $��2��6m   $��	264,7,0,0q�6�   �� 5   
   -   5        $��0��5      $��3��6!   
���  ��$
��Exit��6?   $��2��6e   $��	0,7,264,0q�6y   5      5      