   M S B A M L   `   `   `  ����>  :Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Wpf.View.RegistrationWpf.View.Registration  5      J FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components 5      ,    &Wpf.View.Registration.RegistrationView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Wpf.View.Registration     5      VpasswordAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��800��5
      $
��1100��5      .��5      � .+�5   
   �� 
�������  �� CornerRadius$  20��6#   ._�5      �� $  20��6   ��5      �� 5       �� ResourceKey$ LoginMainBg��6*   ._�5      �  � ColumnDefinitions 5      �� 5      $	��10* �6'   65   �� 5      $	��80* �6'   65   �� 5      $	��10* �6'   65   .+�5      �� $��1��6   
�������$��40,180,40,180q�6<   ._�5!      �  5"      �� 5#      $	��40* �6/   6=   �� 5$      $	��60* �6/   6=   .+�5'      �� $��0��6&   ��5(      �� 5)   "   $ RegistrationBg��6:   .+�5,   "   �� $��Center=�6,   $��	0,150,0,0q�5-   (   $��Log In��5.   (   $��36(�5/   (   $
��Bold"�50   (   
�������$��Century Gothic)�52   (   54   #   �� 56   "   $��Center=�6,   $��0,30,0,0q�57   (   $&�� Enter your username and password��58   (   $��14(�59   (   $��Century Gothic)�5:   (   
�������5=   #   �� 5?   "   $��Center=�6,   $��0,5,0,0q�5@   (   $��to open account��5A   (   $��14(�5B   (   $��Century Gothic)�5C   (   
�������5F   #   �� 5I      -   5         ��Name$ RegistrationBtn��5J      $��0 40 0 0q�5I   !    !  MaterialDesignFlatMidBgButton#��[  5K      $��50��5L      $	��150��5M      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 30,30,30,30��5N      $��16(�5O      
�������  BrushPrimary1#��[ 5Q      
������� � Cursor$
 Hand��5S      ��5T      �� *LogInModuleCommand+.��5X   &   �� ._�5Y   *   � ��5Z   .   �� 5[   2    �� 
TargetType" �68   .�5\   6   ��  �� Property � y� �� Value$ Visible=�6S   	 �� Triggers	 5]   6   �� 5^   :   
 �� Binding
 6F   �� *	IsEnabled+ �� RelativeSource �� *TemplatedParent+ �� Value	 False6�   .a�5_   >   ��  � y�$ 	Collapsed=�6[   5`   ;   5b   3   .+�5e   .   �� $��Center=�6?   $��Center=�6\   $��Log In��6w   � 5g   .    � IsIndeterminate$
 True��5h      $y�	Collapsed=�5i      $	��500��5j      $��55��5k      
���   �$��Center=�5m      $��Center=�5n      
�������5o      5q   +   5s   '   5x   #   5}      � 5�      $��1��6    � RowDefinitions 5�      �� 5�   "   $
��Auto �60   6A   �� 5�   "   $
��Auto �60   6A   �� 5�   "   $
��Auto �61   6A   �� 5�   "   $
��Auto �60   6@   �� 5�   "   $
��Auto �60   6@   �� 5�   &   $
��Auto �64   6D   �� 5�   &   $
��Auto �64   6E   .+�5�      � $��0��6#   .+�5�   "   �� $��Center=�6,   $��Registration��5�   ,   $��0,30,0,0q�5�   ,   $��32(�5�   ,   $
��Bold"�5�   ,   $��Century Gothic)�5�   ,   #��[ 5�   -   5�   #   5�      � 5�   "   $��1��6'   .+�5�   &   �� $��Center=�60   $��0,10,0,0q�5�   (   $/��)Enter your information to register to App��5�   (   $��14(�5�   (   $��Century Gothic)�5�   (   #��[ 5�   (   5�   '   5�   #   � 5�   "   $��2��6'   $��0,30,0,0q�64    5�   &   �� 5�   *   $	��50* �6;   6I   �� 5�   *   $	��50* �6;   6I   .+�5�   *   �� $��0��62   $��Right=�5�   *   $��0,0,10,0q�5�   *   
�������$��2q�5�   *   $	��180��5�   *   $��32��5�   *   $��15(�5�   *   $
��Bold"�5�   *   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$   First name��5�   *   
�������$��5,5,0,0q�5�   *   ��5�   +   �� *	FirstName+5�   (   �� 5�   &   $��1��6.   $��10,0,0,0q�5�   *   $
��Left=�5�   *   
�������$��2q�5�   *   $	��180��5�   *   $��32��5�   *   $��15(�5�   *   $
��Bold"�5�   *   $   Last name��5�   *   
�������$��5,5,0,0q�5�   +   ��5�   +   �� *
LastName+5�   (   5�   #   � 5�   "   $��3��6'   $��0,20,0,0q�64   .+�5�   "   �� $��Center=�5�   *   
�������$��2q�5�   *   $	��380��5�   *   $��32��5�   *   $��15(�5�   *   $
��Bold"�5�   *   $  Email Address��5�   *   
�������$��5,5,0,0q�5�   *   ��5�   *   �� *Email+5�   (   5�      � 5�      $��4��6!   $��0,20,0,0q�6.   .+�5�   "   �� $��Center=�5�   *   
�������$��2q�5�   *   $	��380��5�   *   $��32��5�   *   $��15(�5�   *   $
��Bold"�5�   *   $ 	 Username��5�   *   
�������$��5,5,0,0q�5�   *   ��5�   +   �� *
UserName+5�   (   5�      � 5      $��5��6"   $��0,20,0,0q�6/   .+�5  &   4  .PasswordBoxMVVM.Components.BindablePasswordBox  $��Center=�5  *   
�������$��2q�5  *   $	��380��5  *   $��32��5  *   $��15(�5	  *   $
��Bold"�5
  *   $ 	 Password��5  *   
�������$��5,0,0,0q�5  *      Password 5  *   �� *
Password+5  (   5  #   �� 5     -   5        $ registerBtn��5     $��6��5  !   $��0 20 0 0q�6.   #��[  5     $��32��5     $	��380��5     $��16(�5     
�������#��[ 5     
�������$
 Hand��5!     ��5"     �� *RegisterUserCommand+.��5%  &   �� ._�5&  *   � ��5'  .   �� 5(  2   " �68   .�5)  6   ��  � y�$ Visible=�6S   	 5*  6   �� 5+  :   
 6F   �� *	IsEnabled+ �� *TemplatedParent+	 False6�   .a�5,  >   ��  � y�$ 	Collapsed=�6[   5-  ;   5/  3   .+�52  .   �� $��Center=�6?   $��Center=�6\   $��Register��6w   � 54  .   $
 True��55     $y�	Collapsed=�56     $	��500��57     $��55��58     
���   �$��Center=�5:     $��Center=�5;     
�������5<     5>  +   5@  '   5E  #   5Q     5V     5Y     5_     5c     5e     5g     5i     