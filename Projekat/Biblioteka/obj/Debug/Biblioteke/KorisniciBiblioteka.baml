   M S B A M L   `   `   `  ����  
Biblioteka/    )Biblioteka.Biblioteke.KorisniciBiblioteka   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Korisnici Po Biblioteci��5   	   $	��500��6)   $	��800��66    � 
ResizeMode$ NoResize=�6B    � WindowStartupLocation$ CenterScreen=�6X   .��5	      �� 
�������
�������$��0q�61    �� CornerRadius$ 0��6E   ._�5
   
   � $��20q�6    � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $
��0.2* �6    60   �� 5      $
��0.4* �6    60   �� 5      $
��1.5* �6    60   .+�5      �� -   5        $��naslov��5      $��Center=�6"   $��/��6?   $��20(�6K   $
��Bold"�6Y   �� 5      $��1��6   $��0��6&    �� Orientation$ Vertical=�66   $��0q�6M   .+�5      �� $(��"Unesite deo ili celo ime/prezime: ��6   $��16(�6E   $
��Bold"�6S   �� 5      -   5        $��pretraga��5      $��16(�6*   68   5      &   System.Windows.Controls.DataGrid  5      -   5        $��dataGridSviKorisnici��5   �   $��2��6   $��0��6$   $��14(�64   $��Medium"�6B   ��. $
��Auto=�6{   $��Hidden=�6�      
IsReadOnly .    AutoGenerateColumns .  ��6�   �� *
Korisnik+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Ime��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ��  �� Path$	 Ime�  5      $
 Prezime��6)    6:   �� $ Prezime�  5      $

 JMBG��6)    67   �� $
 Jmbg�  5       $
 Datum učlanjenja��6)    6C   �� $ DatumUclanjenja�  5!      $
 
Biblioteka��6)    6=   �� $ Uclanjen�4  .System.Windows.Controls.DataGridTemplateColumn  5"      $
 Slika��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6<      
IsReadOnly .    CellTemplate 5#      �� 5$      .R�5%   "   �� $��50��6N   ��6(   �� $ ProfilnaSlika�6N   5&      5(      5*      5+      5,      5.      