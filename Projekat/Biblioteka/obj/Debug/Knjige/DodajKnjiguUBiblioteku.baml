   M S B A M L   `   `   `  ����H  DBiblioteka, Version=5.6.2022.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Biblioteka.KnjigeBiblioteka.Knjige  5      .    (Biblioteka.Knjige.DodajKnjiguUBiblioteku   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Biblioteka.Knjige     5        N� Title$  DodajKnjiguUBiblioteku��5	      .��5      �� 
�������
�������$��0q�61    �� CornerRadius$ 20, 20, 20, 20��6E   $��80 70 80 70q�6c   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $
��0.1* �6    60   �� 5      $
��0.7* �6    60   �� 5      $
��0.1* �6    60   .+�5      �� $��0��6   $��0��6!   $��Center=�61   $��IZBOR KNJIGE��6N   $��20(�6e   $
��Bold"�6s   &   System.Windows.Controls.DataGrid  5      -   5        $��dataGridSveKnjige��5   �   $��1��6   $��0��6$   $��Medium"�64   $��14(�6H   $��5 5 5 5q�6V   ��. $
��Auto=�6�   $��Hidden=�6�      
IsReadOnly .    AutoGenerateColumns .  ��6	  �� *Knjiga+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 68   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6B   �� 
 �� Path$
 Naziv�  5      $ Autor��6)   $ * 68   	 6B   �� $
 Autor�  5       $ Godina Izdanja��6)   $ * 6A   	 6K   �� $
 GodinaIzdanja�  5!      $ ID BIBL��6)   $ * 6:   	 6D   �� $
 
NijeDodata�5#      �� 5%      -   5        $��izborKnjigeBtn��5%   K   $��2��6   $��0��6"   $��IZABERI KNJIGU��62   $��	50 5 50 5q�6a   $��16(�6�   $
��Bold"�6�   6�   �� 5(      $��0��6   $��1��6!   $��Center=�61   $��ODABIR BIBLIOTEKE��6N   $��20(�6j   $
��Bold"�6x     5*      -   5        $��dataGridBiblioteke��5*   �   $��1��6   $��1��6$   $��14(�64   $��Medium"�6B   $��5 5 5 5q�6V   ��. $
��Auto=�6�   $��Hidden=�6�    .  .  ��6
  �� *
Biblioteka+ 5+        5,      $ Naziv��6)   	 68   �� $
 Naziv�  5-      $ Adresa��6)   	 69   �� $
 Adresa�  5.      $ Godina Osnivanja��6)   $ * 6C   	 6M   �� $
 GodinaOsnivanja�50      �� 52      -   5        $��dodajUBibliotekuBtn��52   2   $��2��6   $��1��6"   $��	50 5 50 5q�6o   {�.  $��DODAVANJE KNJIGE U BIBL.��6�   $��15(�6�   $
��Bold"�6�   6�   54      55      57      