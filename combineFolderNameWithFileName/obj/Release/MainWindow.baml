   M S B A M L   `   `   `  ���� X  TcombineFolderNameWithFileName, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:combineFolderNameWithFileNamecombineFolderNameWithFileName  .    (combineFolderNameWithFileName.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     =local+clr-namespace:combineFolderNameWithFileName       � Title$  
MainWindow��$	��150��$	��500�� � 	Resources  �� 
TargetType �� Property �� Value��%�   '��       �� " ��.���  � ��$ 30����  � ��$	 100����  � ��
 �������  � ��$ 2q���  � ��$	 2,0q�.��� $��10q� � ColumnDefinitions �� $	��100 ��� $��5 ��� $��* �$	��200���� $��5 ��� $	��130 � � RowDefinitions �� $��50 ��� $��10 ��� $��50 �.+��� $��Folder Path: ��$
��Left=�$	��Top=���  �� TextWrapping$
 Wrap=�$��2��$��1������ *	SourceDir+�� $��Select Folder��$
��Left=�$	��Top=�$��75��$��4������ *OnSelectFolder+�� $��2�� �� Orientation$ 
Horizontal=�$��2��$��2��$��Right=�.+��� $��OK��$
��Left=�$	��Top=�$��75��$��2��$��1������ *OnMove+�� -   $��Cancel��$
��Left=�$	��Top=�$��75��	 J� RenderTransformOrigin$	 -0.733,-5.75&�$��1��$��1���� $��Remove��$��2��$��5��
 d� 	IsChecked
 �� *RemoveAfterCopied+