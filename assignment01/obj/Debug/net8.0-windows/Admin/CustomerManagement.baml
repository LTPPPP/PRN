   M S B A M L   `   `   `  ����G  Cassignment01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:assignment01.ViewModelsassignment01.ViewModels  5      9!clr-namespace:assignment01.Modelsassignment01.Models  5      %    assignment01.CustomerManagement   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:assignment01.ViewModels     5      4models!clr-namespace:assignment01.Models     5        N� Title$  CustomerManagement��5
       N� 
Background
 ��� �.��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $
��0.5* �6   6,    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��4* �6   6,   �� 5      $
��0.8* �6   6.   �� 5      $
��0.8* �6   6.   �� 5      $
��0.8* �6   6.   .+�5!   
   �� $��1��6   $��0��6!   $��ID : ��61   $��18(�6>   $
��Bold"�6L   $��Right=�6^   $��3,3,3,3q�6z   �� 5"   
   $��2��6   $��0��6!   $��FullName : ��61   $��18(�6D   $
��Bold"�6R   $��Right=�6d   $��3,3,3,3q�6�   �� 5#   
   $��3��6   $��0��6!   $��Tele : ��61   $��18(�6@   $
��Bold"�6N   $��Right=�6`   $��3,3,3,3q�6|   �� 5$   
   $��4��6   $��0��6!   $��Email : ��61   $��18(�6A   $
��Bold"�6O   $��Right=�6a   $��3,3,3,3q�6}   �� 5%   
   $��5��6   $��0��6!   $��BirthDay : ��61   $��18(�6D   $
��Bold"�6R   $��Right=�6d   $��3,3,3,3q�6�   �� 5&   
   $��6��6   $��0��6!   $��	Status : ��61   $��18(�6B   $
��Bold"�6P   $��Right=�6b   $��3,3,3,3q�6~   �� 5'   
   $��7��6   $��0��6!   $��Password : ��61   $��18(�6D   $
��Bold"�6R   $��Right=�6d   $��3,3,3,3q�6�   �� 5)   
   -   5        $��CustomerID_txtBox��5)      $��1��6   $��1��68   $��18(�6H   $��3,3,3,3q�6V    �� 
IsReadOnly$
 True��6�   ��6g   �� *
CustomerId+ �� Mode$ TwoWay=�6�   �� 5*   
   -   5        $��CustomerFullName_txtBox��5*      $��2��6   $��1��6>   $��18(�6N   $��3,3,3,3q�6\   ��6m   �� *CustomerFullName+$ TwoWay=��� 5+   
   -   5        $��CustomerTele_txtBox��5+      $��3��6   $��1��6:   $��18(�6J   $��3,3,3,3q�6X   ��6i   �� *	Telephone+$ TwoWay=��� 5,   
   -   5        $��CustomerEmail_txtBox��5,      $��4��6   $��1��6;   $��18(�6K   $��3,3,3,3q�6Y   ��6j   �� *EmailAddress+$ TwoWay=��� 5-   
   -   5        $��CustomerBirthDay_txtBox��5-      $��5��6   $��1��6>   $��18(�6N   $��3,3,3,3q�6\   ��6m   �� *CustomerBirthday+$ TwoWay=��� 5.   
   -   5        $��CustomerStatus_txtBox��5.      $��6��6   $��1��6<   $��18(�6L   $��3,3,3,3q�6Z   ��6k   �� *CustomerStatus+$ TwoWay=��� 5/   
   -   5        $��CustomerPass_txtBox��5/      $��7��6   $��1��6:   $��18(�6J   $��3,3,3,3q�6X   ��6i   �� *
Password+$ TwoWay=��� 54   
   $��1��6   $��2��6   $	��Add��6.   $��18(�6<   $
��Bold"�6J   $��3,3,3,3q�6\   ��6m   �� *AddCustomerCommand+�� 55   
   $��1��6   $��3��6   $��Update��6.   $��18(�6?   $
��Bold"�6M   $��3,3,3,3q�6_   ��6p   �� *UpdateCustomerCommand+�� 56   
   $��1��6   $��4��6   $��Delete��6.   $��18(�6?   $
��Bold"�6M   $��3,3,3,3q�6_   ��6p   �� *DeleteCustomerCommand+�� 59   
   -   5        $��CustomerListView��59   D   $��0��6   $��0��6    $��5��60   $��15(�5<      $
��Bold"�6!   ��5:      �� *	Customers+ �� SelectedItem 5;      �� *SelectedCustomer+ �� View 5=      �� 5>      .P�5?      �� $��
CustomerId��6%    �� Width$
 Auto��69   	 �� DisplayMemberBinding	 6F   �� *
CustomerId+�� 5@      $��CustomerFullName��6%   $
 Auto��6?   	 6L   �� *CustomerFullName+�� 5A      $��	Telephone��6%   $
 Auto��68   	 6E   �� *	Telephone+�� 5B      $��Email��6%   $
 Auto��64   	 6A   �� *EmailAddress+�� 5C      $��BirthDay��6%   $
 Auto��67   	 6D   �� *CustomerBirthday+�� 5D      $��Status��6%   $
 Auto��65   	 6B   �� *CustomerStatus+5E      5G      5H      5I      