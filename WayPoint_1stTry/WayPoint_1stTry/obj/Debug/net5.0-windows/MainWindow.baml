   M S B A M L   `   `   `  ����J  FWayPoint_1stTry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WayPoint_1stTryWayPoint_1stTry  5   	   G(clr-namespace:WayPoint_1stTry.ViewModelsWayPoint_1stTry.ViewModels  5   	   ?$clr-namespace:WayPoint_1stTry.HelperWayPoint_1stTry.Helper  5   
        WayPoint_1stTry.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WayPoint_1stTry     5   	   7vm(clr-namespace:WayPoint_1stTry.ViewModels     5   	   7helper$clr-namespace:WayPoint_1stTry.Helper     5   
     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � DataContext 5      .   (WayPoint_1stTry.ViewModels.MainViewModel  5   
   6    � 	Resources 5      &    WayPoint_1stTry.Helper.Converter   	converter0   *WayPoint_1stTry.Helper.DifficultyConverter  difConverter��%:   &	        &	        5   
   6/     5   
   6<   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� $��0��6   ��6"   �� *	FirstList+ �� SelectedItem 6D   �� *SelectedPoint1+��5      �� 5      .R�5      �� .+�5      �� ��6    �� *	PointCode+6@   �� 5      ��6    �� *X+68   �� 5      ��6    �� *Y+68   �� 5       ��6    �� *Height+6=   �� 5!      ��6    �� *
Category+6?   5"      5#      5%      �� 5&   
   $��1��6   .+�5'      �� $	��Add��6   ��6#   �� *Add+6=   �� 5(      $
��Edit��6   ��6$   �� *Edit+6?   �� 5)      $��Delete��6   ��6&   �� *Delete+6C   �� 5*      $
��Save��6   ��6$   �� *Save+6?   5+      �� 5,   
   $��2��6   ��6"   �� *SecondsList+ 6F   �� *SelectedPoint2+��5-      �� 5.      .R�5/      �� .+�50      �� ��6    �� *	PointCode+6@   �� 51      ��6    �� *X+68   �� 52      ��6    �� *Y+68   �� 53      ��6    �� *Height+6=   54      55      57      �� 58   
   $��3��6   ��6"   �� *Hikes+��59      �� 5:      .R�5;      �� .+�5<      �� ��6    �� *ListOfPoints+ �� 	Converter# [  6j   �� 5=      ��6    �� *
DateOfHike+6A   �� 5>       � Minimum$ 0Q�6f    � Maximum$ 15Q�6r    � Value 6!   �� *
Difficulty+# [ 6�   5?      5@      5B      5C      5D      