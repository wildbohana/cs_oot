   M S B A M L   `   `   `  ����H  DBiblioteka, Version=5.6.2022.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Biblioteka.BibliotekeBiblioteka.Biblioteke  5   	   (    "Biblioteka.Biblioteke.SpisakKnjiga   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Biblioteka.Biblioteke     5   	     � Title$  Spisak Knjiga��5   	   $	��450��6   $	��600��6,    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ NoResize=�6]   .��5
      �� 
�������
�������$��0q�64    �� CornerRadius$ 20, 20, 20, 20��6H   ._�5   
   � $��20q�6    � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $
��0.2* �6    60   �� 5      $
��0.5* �6    60   �� 5      $��* �6    6-   .+�5      �� -   5        $��naslov��5      $��Center=�6"   $��/��6?   $��20(�6K   $
��Bold"�6Y   �� 5      $��1��6   $��0��6&    �� Orientation$ Vertical=�66   $��0q�6M   .+�5      �� $3��-Unesite deo ili ceo naziv knjige ili autora: ��6   $��16(�6P   $
��Bold"�6^   �� 5      -   5        $��pretraga��5      $��16(�6*   68   5      &   System.Windows.Controls.DataGrid  5      -   5        $��knjigePoBiblioteci��5   �   $��2��6   $��0��6$   $��Medium"�64   $��16(�6H   ��. $
��Auto=�6{   $��Hidden=�6�      
IsReadOnly .    AutoGenerateColumns .  ��6�   �� *Knjiga+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Naziv��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   ��  �� Path$ Naziv�  5      $
 Autor��6)    68   �� $ Autor�  5       $
 Godina Izdanja��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 100* 6h    6A   �� $ GodinaIzdanja�6h   5"      5#      5$      5&      