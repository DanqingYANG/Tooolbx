   M S B A M L   `   `   `  ����X  TcombineFolderNameWithFileName, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:combineFolderNameWithFileNamecombineFolderNameWithFileName  5   	   7    1combineFolderNameWithFileName.EmptyFolderSelector   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:combineFolderNameWithFileName     5   	     � Title$  EmptyFolderSelector��5   	   $	��450��5	   	   $	��500��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         TreeViewItemStyle �� 
TargetType �� Property �� Value �� Mode-  'System.Windows.Input.KeyboardNavigation  CheckBoxItemTemplate �� ItemsSource �� Orientation	 d� 	IsChecked�� 5   
   %  &	        &	 �     �� 5      " Q�5      .�5      ��  �@Q�
IsExpanded . 5      �� 5       �@Q�
IsSelected 5      �� *IsInitiallySelected+$ OneTime=��� 5       �@ AcceptsReturn . 5      5      �� 5       5   '   �� *
Children+$ OneTime=�.R�5      �� $ 
Horizontal=�6   .+�5      �� |�.  $��Center=�5      	 5      �� *	IsChecked+5      �� 5      $	��2,0q�5   '   ��5   '   �� *Name+$ OneTime=�5   '   5      5       5!      .��5$      � 
 � ColumnDefinitions
 5%   
   �� 5&      6!   �� 5'      $	��155 �6   6-    � RowDefinitions 5)   
   �� 5*      6   �� 5+      $��60 �6   6*   .+�5.   
   R� -   5         R�Name$ tv��5.      $��0��5/      $��0��50      $��10q�51      #��[  53      #��[ 54      ��52      �� *FolderSelectors+54      �� 56   
   $��1��6   $��0��57      $	��135��58      $��10q�59      $	��Top=�5:      .+�5<      �� $��Select Empty Folders��6   $��0,0,0,10q�5=      ��5>      �� *	OnDefault+�� 5?      $��
Select All��6   $��0,0,0,10q�5@      ��5A      �� *
OnCheckAll+�� 5B      $��Select None��6   $��0,0,0,10q�5C      ��5D      �� *OnUnCheckAll+5E      �� 5F   
   $��1��6   $��1��5G      $��Bottom=�5H      $��10q�5I      .+�5J      �� $��Remove��6   $��0q�5K      ��5L      �� *
OnRemove+5M      5O      5P      