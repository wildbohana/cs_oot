   M S B A M L   `   `   `  ����H  DBiblioteka, Version=5.6.2022.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Biblioteka.KorisniciBiblioteka.Korisnici  5      *    $Biblioteka.Korisnici.IzmeniKorisnika   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Biblioteka.Korisnici     5        N� Title$  IzmeniKorisnika��5	      .��5      �� 
�������
�������$��0q�64    �� CornerRadius$ 20, 20, 20, 20��6H   $��80 70 80 90q�6f   ._�5   
   � $��20q�6    � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $
��0.32 �6    60   �� 5      $
��0.4* �6    60   �� 5      $��* �6    6-   .+�5      �� $��1��6   $��0��6&    �� Orientation$ Vertical=�66   $��0q�6M   .+�5      �� $)��#Unesite ime ili prezime korisnika: ��6   $��16(�6F   $
��Bold"�6T   �� 5      -   5        $��pretraga��5      $��14(�6*   68   5      �� 5      $��0��6   $��0��6!   $��Center=�61   $?��9ODABERITE DUPLIM KLIKOM KORISNIKA KOG ŽELITE DA IZMENITE��6N   $��18(�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5      -   5        $��dataGridSviKorisnici��5   �   $��2��6   $��0��6$   $��Medium"�64   $��14(�6H   ��. $
��Auto=�6{   $��Hidden=�6�      
IsReadOnly .    AutoGenerateColumns .  ��6�   �� *
Korisnik+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$	 Ime��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 66   �� 
 �� Path$	
 Ime�  5!      $ Prezime��6)   	 6:   �� $
 Prezime�  5"      $
 JMBG��6)   	 67   �� $

 Jmbg�  5#      $ Datum učlanjenja��6)   	 6C   �� $
 DatumUclanjenja�  5$      $ 
Biblioteka��6)   	 6=   �� $
 Uclanjen�4  .System.Windows.Controls.DataGridTemplateColumn  5&      $ Slika��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6<      
IsReadOnly .    CellTemplate 5'      �� 5(      .R�5)   "   �� $��50��6N   ��6(   �� $
 ProfilnaSlika�6N   5*      5,      5.      5/      50      52      