   M S B A M L   `   `   `  ����E  ASilverProg, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SilverProg
SilverProg  5   	   '    !SilverProg.Авторизация   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SilverProg     5   	     � Title$  Авторизация��5   	   $	��375��6   $	��400��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��55* �6   �� 5      $	��65* �6   �� 5      $	��65* �6   �� 5      $��90 �6   .+�5   
   �� $��2��6   $��0��6!   �� 5   
   $5��/Авторизация пользователя��6   $��Center=�63   $	��320��6P   $��50��6\   $��0��6h   $��Bottom=�6u   $��20(�6�   $��2��6�   $��	62,0,10,0q�6�   �� 5   
   -   5         ��Name$ Vvodlog��5      $"��Выберите логин:��6!   $��Center=�6<   $��32��6Y   $��1��6e   $��0��6r   $��16(�6�   $��Center=�6�   $��
16,18,23,5q�6�   $	��157��6�   6�   �� 5   
   -   5        $ Vvodpar��5      $"��Введите пароль:��6!   $��Center=�6;   $��30��6X   $��2��6d   $��0��6q   $��16(�6�   $��Center=�6�   $��18,28,23,16q�6�   $	��155��6�   6�   �� 5   
   -   5        $��ViborLog��5       �� DisplayMemberPath$ Login��6%   $
��Left=�6?   $	��150��6[   $��1��6g   $��30��6t   $��1��6�   $��
25,15,0,10q�6�   G� 5   
   -   5         G�Name$ Spispar��5   k   $��Center=�6   $��Center=�6;   $��16(�6]   $
��Left=�6|   $��30��6�   $��2��6�   $��1��6�   $��Center=�6�   $	��150��6�   $��
25,28,0,16q�6�   6�   �� 5   
   -   5         ��Name$ Voiti��5      $��
Войти��6    $
��Left=�60   $��36��6K   $��4��6W   $��Center=�6d   $	��150��6   $��18(�6�   $��
25,20,0,17q�6�   $��1��6�   5      5      