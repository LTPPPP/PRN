   M S B A M L   `   `   `  ����G  Cassignment01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:assignment01assignment01  5      A%clr-namespace:assignment01.ViewModelsassignment01.ViewModels  5      "    assignment01.CustomerProfile   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:assignment01     5      <
viewModels%clr-namespace:assignment01.ViewModels     5        N� Title$  CustomerProfile��5
       N� 
Background
 ��� � � 	Resources 5          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5       � DataContext 5      6   0assignment01.ViewModels.CustomerProfileViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��20q�6"   .+�5      �� $��Customer Full Name:��6   $
��Bold"�63   �� 5      $
��auto��6g   $��0,5,0,10q�6t   ��6   �� *Customer.CustomerFullName+ �� 
IsReadOnly 6A   �� *IsReadOnlyMode+6t   �� 5      $��
Telephone:��6   $
��Bold"�6*   �� 5      $
��auto��6`   $��0,5,0,10q�6m   ��6   �� *Customer.Telephone+ 6:   �� *IsReadOnlyMode+6m   �� 5!      $��Email Address:��6   $
��Bold"�6.   �� 5"      $
��auto��6c   $��0,5,0,10q�6p   ��6   �� *Customer.EmailAddress+ 6=   �� *IsReadOnlyMode+6p   �� 5$      $��Customer Birthday:��6   $
��Bold"�62   �� 5%      $
��auto��6g   $��0,5,0,10q�6t   ��6   �� *Customer.CustomerBirthday+ 6A   �� *IsReadOnlyMode+6t   �� 5'      $��Customer Status:��6   $
��Bold"�60   �� 5(      $
 True��6J   $
��auto��6\   $��0,5,0,10q�6i   ��6   �� *CustomerStatusDisplay+ �� Mode$ OneWay=�6i   �� 5*       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5+      �� $
��Edit��6   $��	0,10,10,0q�6H   ��6(   �� *EditCommand+y�6[   �� *IsReadOnlyMode+ �� 	Converter# [  �� 5,      $��Save Changes��6   $��0,10,0,0q�6W   ��60   �� *SaveChangesCommand+y�6i   �� *
IsEditMode+# [  5-      5.      5/      50      