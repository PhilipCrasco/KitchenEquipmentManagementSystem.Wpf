   M S B A M L   `   `   `  ����J  FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components  5      > :Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Wpf.View.LoginWpf.View.Login 5      9!clr-namespace:Wpf.ViewModel.LoginWpf.ViewModel.Login 5	         Wpf.View.Login.LoginView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      VpasswordAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     5      .localclr-namespace:Wpf.View.Login     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      6loginviewmodel!clr-namespace:Wpf.ViewModel.Login  5	      $	��800��5      $
��1100��5      .��5      � .+�5   
   �� 
�������  �� CornerRadius$  20��6#   ._�5   
   �� $  20��6   ��5      �� 5       �� ResourceKey$ LoginMainBg��6*   ._�5      �  � ColumnDefinitions 5      �� 5       $	��10* �6'   65   �� 5!      $	��80* �6'   65   �� 5"      $	��10* �6'   65   .+�5%      �� $��1��6   
�������$��130,220,130,220q�6<   ._�5'      �  5(      �� 5)      $	��40* �6/   6=   �� 5*      $	��60* �6/   6=   .+�5-      �� $��0��6&   ��5.      �� 5/   "   $ RegistrationBg��6:   .+�52      �� $��Center=�6(   $��	0,100,0,0q�53   (   $��Register��54   (   $��30(�55   (   $
��Bold"�56   (   
�������$��Century Gothic)�58   (   5:      �� 5<      $��Center=�6(   $��0,30,0,0q�5=   (   $"��Enter your personal info and��5>   (   $��11(�5?   (   $��Century Gothic)�5@   (   
�������5C      �� 5E      $��Center=�6(   $��0,5,0,0q�5F   (   $��new account��5G   (   $��11(�5H   (   $��Century Gothic)�5I   (   
�������5L      �� 5P      -   5         ��Name$ RegistrationBtn��5Q      $��0 30 0 0q�5P   %    !  MaterialDesignFlatMidBgButton#��[  5R      $��50��5S      $	��150��5T      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 30,30,30,30��5U      $��16(�5V      
�������  BrushPrimary1#��[ 5X      
������� � Cursor$
 Hand��5Z      ��5[      �� *RegistrationCommand+.��5^   "   �� ._�5_   &   � ��5`   *   �� 5a   .    �� 
TargetType" �64   .�5b   2   ��  �� Property � y� �� Value$ Visible=�6O   	 �� Triggers	 5c   2   �� 5d   6   
 �� Binding
 6B   �� *	IsEnabled+ �� RelativeSource �� *TemplatedParent+ �� Value	 False6�   .a�5e   :   ��  � y�$ 	Collapsed=�6W   5f   7   5h   /   .+�5k   *   �� $��Center=�6;   $��Center=�6X   $��Register��6s   � 5m   *    � IsIndeterminate$
 True��5n      $y�	Collapsed=�5o      $	��500��5p      $��55��5q      
���   �$��Center=�5s      $��Center=�5t      
�������5u      5w   '   5y   #   5~      5�      �� 5�      $��1��6%   .+�5�      �� $��Welcome��6(   $��Center=�5�   (   $��0,50,0,0q�5�   (   $��25(�5�   (   $
��Bold"�5�   (   #��[ 5�   (   6V   �� 5�      $ ��Please log in your Account��6(   $��Center=�5�   (   $��0,10,0,0q�5�   (   $��12(�5�   (   #��[ 5�   (   6V   �� 5�      $��0 25 0 0q�6&   $	��230��5�       $��30��5�       $��14(�5�       
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$  Enter User Name��5�       $��2q�5�       #��[ 5�       ��5�       �� *
Username+ �� Mode$ TwoWay=�.��5�      5�      4   .PasswordBoxMVVM.Components.BindablePasswordBox  5�      $��0 15 0 0q�6<   $	��230��5�       $��30��5�       $��14(�5�       
�������$  Enter Password��5�       $��2q�5�       #��[ 5�          Password 5�       �� *
Password+$ TwoWay=��� 5�      -   5        $ registerBtn��5�      $��0 30 0 0q�5�   %   #��[  5�      $��30��5�      $	��200��5�      $ 20,20,20,20��5�      $��16(�5�      
�������#��[ 5�      
�������$
 Hand��5�      ��5�      �� *LoginCommand+.��5�   "   �� ._�5�   &   � ��5�   *   �� 5�   .   " �64   .�5�   2   ��  � y�$ Visible=�6O   	 5�   2   �� 5�   6   
 6B   �� *	IsEnabled+ �� *TemplatedParent+	 False6�   .a�5�   :   ��  � y�$ 	Collapsed=�6W   5�   7   5�   /   .+�5�   *   �� $��Center=�6;   $��Center=�6X   $��Log in��6s   � 5�   *   $
 True��5�      $y�	Collapsed=�5�      $	��500��5�      $��55��5�      
���   �$��Center=�5�      $��Center=�5�      
�������5�      5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      5�      