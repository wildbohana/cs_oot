   M S B A M L   `   `   `  ����H  DBiblioteka, Version=5.6.2022.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Biblioteka.BibliotekeBiblioteka.Biblioteke  5      7    1Biblioteka.Biblioteke.SpisakBibliotekaPoKorisniku   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Biblioteka.Biblioteke     5        N� Title$!  SpisakBibliotekaPoKorisniku��5	      .��5      �� 
�������
�������$��0q�61    �� CornerRadius$ 20, 20, 20, 20��6E   $��80 70 80 90q�6c   ._�5   
   � $��20q�6    � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $
��0.2* �6    60   �� 5      $
��0.5* �6    60   �� 5      $��* �6    6-   .+�5      �� -   5        $��naslov��5      $��Center=�6"   $<��6ODABERITE DUPLIM KLIKOM BIBLIOTEKU ZA PRIKAZ KORISNIKA��6?   $��20(�6�   $
��Bold"�6�   �� 5      $��1��6   $��0��6&    �� Orientation$ Vertical=�66   $��0q�6M   .+�5      �� $��Unesite ime biblioteke: ��6   $��16(�6;   $
��Bold"�6I   �� 5      -   5        $��pretraga��5      $��16(�6*   68   5      &   System.Windows.Controls.DataGrid  5      -   5        $��dataGridSveBiblioteke��5   �   $��2��6   $��0��6$   $��14(�64   $��Medium"�6B   ��. $
��Auto=�6{   $��Hidden=�6�      
IsReadOnly .    AutoGenerateColumns .  ��6�   �� *
Biblioteka+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 100* 68   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6E   ��  �� Path$ Naziv�  5       $ Adresa��6)   $
	 100* 69   
 6F   �� $ Adresa�  5!      $ Godina Osnivanja��6)   $
	 100* 6C   
 6P   �� $ GodinaOsnivanja�4  .System.Windows.Controls.DataGridTemplateColumn  5#      $
 Logo��6-   $		 50* 6;      
IsReadOnly .    CellTemplate 5$      �� 5%      .R�5&   "   �� $��50��6O   ��6(   �� $ LogoBiblioteke�6O   5'      5)      5+      5,      5-      5/      