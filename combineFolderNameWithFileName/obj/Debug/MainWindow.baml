   M S B A M L   `   `   `  ����X  TcombineFolderNameWithFileName, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:combineFolderNameWithFileNamecombineFolderNameWithFileName  5   	   .    (combineFolderNameWithFileName.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:combineFolderNameWithFileName     5   	     � Title$  
MainWindow��5   	   $	��150��5	   	   $	��500��5
   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 30��5      �� 5       � ��$	 100��5      �� 5       � ��
 �����5      �� 5       � ��$ 2q�5      �� 5       � ��$	 2,0q�5      5      5      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      $��5 �6   �� 5      $��* �6   $	��200��6)   �� 5       $��5 �6   �� 5!      $	��130 �6    � RowDefinitions 5#   
   �� 5$      $��50 �6   6*   �� 5%      $��10 �6   6*   �� 5&      $��50 �6   6*   .+�5)   
   �� $��Folder Path: ��6   $
��Left=�5*      $	��Top=�5+      �� 5-   
    �� TextWrapping$
 Wrap=�6   $��2��5/      $��1��50      ��5.      �� *	SourceDir+50      �� 52   
   $��Select Folder��6   $
��Left=�53      $	��Top=�54      $��75��55      $��4��56      ��57      �� *OnSelectFolder+�� 59   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��2��6;   $��2��6K   $��Right=�6_   .+�5:      �� $��OK��6   $
��Left=�5;      $	��Top=�5<      $��75��5=      $��2��5>      $��1��5?      ��5@      �� *OnMove+�� 5A      -   5        $��Cancel��5A      $
��Left=�5B      $	��Top=�5C      $��75��5D      	 J� RenderTransformOrigin$	 -0.733,-5.75&�5E      $��1��5F      $��1��5G      5H      5I      �� 5K   
   $��Remove��6   $��2��5L      $��5��5M      
 d� 	IsChecked
 5N      �� *RemoveAfterCopied+5O      5P      