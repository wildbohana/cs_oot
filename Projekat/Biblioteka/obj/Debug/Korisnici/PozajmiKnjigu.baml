   M S B A M L   `   `   `  ����H  DBiblioteka, Version=5.6.2022.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Biblioteka.KorisniciBiblioteka.Korisnici  5      (    "Biblioteka.Korisnici.PozajmiKnjigu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Biblioteka.Korisnici     5        N� Title$  PozajmiKnjigu��5	      .��5      �� 
�������
�������$��0q�64    �� CornerRadius$ 20, 20, 20, 20��6H   $��80 70 80 70q�6f   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $
��0.1* �6    60   �� 5      $
��0.7* �6    60   �� 5      $
��0.1* �6    60   .+�5      �� $��0��6   $��0��6!   $��Center=�61   $��IZBOR KORISNIKA��6N   $��20(�6h   $
��Bold"�6v   &   System.Windows.Controls.DataGrid  5      -   5        $��dataGridSviKorisnici��5   �   $��1��6   $��0��6$   $��Medium"�64   $��14(�6H   $��5 5 5 5q�6V   ��. $
��Auto=�6�   $��Hidden=�6�      
IsReadOnly .    AutoGenerateColumns .  ��6  �� *
Korisnik+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Ime��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 100* 66   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6C   �� 
 �� Path$	
 Ime�  5      $ Prezime��6)   $
 100* 6:   	 6G   �� $
 Prezime�  5      $
 JMBG��6)   $	 120 67   	 6C   �� $

 Jmbg�  5       $ 
Biblioteka��6)   $
 140* 6=   	 6J   �� $
 Uclanjen�5"      �� 5$      -   5        $��izborKorisnikaBtn��5$   N   $��2��6   $��0��6"   $��IZABERI KORISNIKA��62   $��	50 5 50 5q�6g   $��16(�6�   $
��Bold"�6�   6�   �� 5'      $��0��6   $��1��6!   $��Center=�61   $"��DOSTUPNE KNJIGE U BIBLIOTECI��6N   $��20(�6u   $
��Bold"�6�     5)      -   5        $��dataGridDostupneKnjige��5)   �   $��1��6   $��1��6$   $��Medium"�64   $��14(�6H   $��5 5 5 5q�6V   ��. $
��Auto=�6�   $��Hidden=�6�    .  .  ��6  �� *	Knjiga_+ 5*        5+      $ Naziv��6)   $
 100* 68   	 6E   �� $
 Naziv�  5,      $ Autor��6)   $
 100* 68   	 6E   �� $
 Autor�  5-      $ Godina Izdanja��6)   $
 100* 6A   	 6N   �� $
 GodinaIzdanja�5/      �� 51      -   5        $��pozajmiKnjiguBtn��51   2   $��2��6   $��1��6"   $��	50 5 50 5q�6i   {�.  $��POZAJMI KNJIGU��6�   $��16(�6�   $
��Bold"�6�   6�   52      53      55      