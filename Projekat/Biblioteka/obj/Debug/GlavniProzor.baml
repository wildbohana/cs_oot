   M S B A M L   `   `   `  ����  
Biblioteka    Biblioteka.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$- 'Biblioteka | Predmetni Projekat 2021/22��5      $	��600��68   $
��1100��6E    � Icon$ Slike/ikonica.ico��6R    � WindowStartupLocation$ CenterScreen=�6k   .��5
      � ��5   
   �� 5       �� ImageSource$ /Slike/bg.png��6    j� Stretch$ UniformToFill=�65    � ColumnDefinitions 5   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��24 �6   6*   �� 5      $��* �6   6)   .+�5   
   ]� $��0��6   $��0��6$   $��2��61   $��
0,0,-0.4,0q�6E   .+�5      o� $	��Top=�6   ���#fff
���   �.@�5      m� $��
Biblioteke��6   $��16(�61   $��Medium"�6?    m� Icon 5      �� 5      $��/Slike/biblioteka.png��6    6A   .@�5!      m� -   5        $��dodajBibliotekuStrana��5!   ?   $��Dodavanje biblioteke��6   $
��Left=�6�   $	��300��6�    5"      �� 5#      $��/Slike/dodaj.png��6$   6@   5%      m� 5&      -   5        $��izmenaBiblioteke��5&   G   $"��Izmena podataka o biblioteci��6   $
��Left=�6~   $	��300��6�    5'      �� 5(      $��/Slike/izmena.png��6$   6A   5*      m� 5+      -   5        $��brisanjeBiblioteke��5+   >   $��Brisanje biblioteke��6   $
��Left=�6y   $	��300��6�    5,      �� 5-      $��/Slike/minus.png��6$   6@   5/      m� 50      -   5        $��pregledSvihBiblioteki��50   G   $"��Pregled knjiga po biblioteci��6   $
��Left=�6�   $	��300��6�    51      �� 52      $��/Slike/pregled.png��6$   6B   54      m� 55      -   5        $"��pregledKorinsikaPoBiblioteci��55   J   $%��Pregled korisnika po biblioteci��6   $
��Left=�6�   $	��305��6�    56      �� 57      $��/Slike/korisnik.png��6$   6C   59      5:      m� 5=      $��	Korisnici��6   $��16(�60   $��Medium"�6>    5>      �� 5?      $��/Slike/korisnik.png��6    6?   .@�5A      m� -   5        $��dodajKorisnika��5A   >   $��Dodavanje korisnika��6   $
��Left=�6q   $	��300��6�    5B      �� 5C      $��/Slike/dodaj.png��6$   6@   5E      m� 5F      -   5        $��izmeniKorisnika��5F   F   $!��Izmena podataka o korisniku��6   $
��Left=�6{   $	��300��6�    5G      �� 5H      $��/Slike/izmena.png��6$   6A   5J      m� 5K      -   5        $��brisanjeKorisnika��5K   =   $��Brisanje korisnika��6   $
��Left=�6v   $	��300��6�    5L      �� 5M      $��/Slike/minus.png��6$   6@   5O      m� 5P      -	   5        $��pregledSvihKorinsika��5P   <   $��Pregled korisnika��6   $
��Left=�6{   $	��300��6�    5Q      �� 5R      $��/Slike/pregled.png��6$   6B   5T      m� 5U      -
   5        $��uclaniKorisnika��5U   H   $$��Učlani korisnika u biblioteku��6   $
��Left=�6}   $	��300��6�    5V      �� 5W      $��/Slike/uclani.png��6$   6A   5Y      5Z      m� 5]      $��Knjige��6   $��16(�6-   $��Medium"�6;    5^      �� 5_      $��/Slike/knjiga.png��6    6=   .@�5a      m� -   5        $��dodajKnjigu��5a   f   $��Dodavanje knjige��6   $
��Left=�6;   $	��300��6X    5b      �� 5c      $��/Slike/dodaj.png��6$   6@   5e      m� 5f      -   5        $��izmeniKnjigu��5f   n   $��Izmena podataka o knjizi��6   $
��Left=�6C   $	��300��6`    5g      �� 5h      $��/Slike/izmena.png��6$   6A   5j      m� 5k      -   5        $��brisanjeKnjige��5k   f   $��Brisanje knjige��6   $
��Left=�6:   $	��300��6W    5l      �� 5m      $��/Slike/minus.png��6$   6@   5o      m� 5p      -   5        $��pregledSvihKnjiga��5p   e   $��Pregled knjiga��6   $
��Left=�69   $	��300��6V    5q      �� 5r      $��/Slike/pregled.png��6$   6B   5t      m� 5u      -   5        $��pozajmiKnjigu��5u   G   $"��Pozajmi knjigu iz biblioteke��6   $
��Left=�6x   $	��300��6�    5v      �� 5w      $��/Slike/pozajmi.png��6$   6B   5y      m� 5z      -   5        $��dodajKnjiguUBiblioteku��5z   D   $��Dodaj knjigu u biblioteku��6   $
��Left=�6�   $	��300��6�    5{      �� 5|      $��/Slike/dodaj.png��6$   6@   5~      5      m� 5�      -   5        $��	oprogramu��5�   S   $��
O Programu��6   $��16(�61   $��Medium"�6?    5�      �� 5�      $��/Slike/about.png��6    6<   5�      5�      5�       � 5�   
   -   5        $��	aktivnost��5�   )   	  � NavigationUIVisibility$	 Hidden=�6:   $��1��6Z   
  � Source$
 Program/Pocetna.xaml?�6g   $��2��6�   $��0,0,-0.4,0.4q�6�   5�      5�      