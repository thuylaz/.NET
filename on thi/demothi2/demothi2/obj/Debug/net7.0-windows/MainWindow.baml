   M S B A M L   `   `   `  ����C  ?demothi2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:demothi2demothi2  5   	       demothi2.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:demothi2     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
         btt �� 
TargetType  text �� 
TargetType �� Property �� Value  cb  dtg=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	 |     &	 �     &	 n    �� 5   
   " ��6&   .R�5      � .+�5      �� 
����ح�6   �� 5      $��Center=�6#   5      5      �� 5   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   �� 5       � ��$ 15(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ Times New Roman)�6+   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�64   5      5      .��5      � .+�5    
   �� $��	Mã sách��6   $
��Left=�6"   $��	86,32,0,0q�6=   $	��Top=�6P   $��Times New Roman)�6h   $��15(�6�   �� 5!   
   $��
Tên sách��6   $
��Left=�6#   $��	86,80,0,0q�6>   $	��Top=�6Q   $��Times New Roman)�6i   $��15(�6�   �� 5"   
   $��Nhà xuất bản��6   $
��Left=�6'   $��
86,127,0,0q�6B   $	��Top=�6V   $��Times New Roman)�6n   $��15(�6�   �� 5#   
   $��
Số trang��6   $
��Left=�6#   $��
86,171,0,0q�6>   $	��Top=�6R   $��Times New Roman)�6j   $��15(�6�   �� 5$   
   -   5        #��[  5$      $��Thêm��62   $
��Left=�6A   $��
575,64,0,0q�6\   $	��Top=�6p   $��Times New Roman)�6�   $��15(�6�   $��70��6�   6�   �� 5%   
   -   5        #��[  5%      $
��Tìm��62   $
��Left=�6@   $��575,119,0,0q�6[   $	��Top=�6p   $��Times New Roman)�6�   $��15(�6�   $��70��6�   6�   �� 5&   
   -   5        #��[  5&      $
��Xóa��62   $
��Left=�6@   $��575,167,0,0q�6[   $	��Top=�6p   $��Times New Roman)�6�   $��15(�6�   $��70��6�   6�   �� 5'   
   -   5        #��[  5'      $��Sửa��62   $
��Left=�6@   $��	575,0,0,0q�6[   $��Center=�6n   $��Times New Roman)�6�   $��15(�6�   $��70��6�   6�   �� 5)   
   -   5         ��Name$ 	txtmasach��5)      $
��Left=�6%   #��[ 6@   $��
307,40,0,0q�6^    �� TextWrapping$
 Wrap=�6r   $	��Top=�6�   $	��120��6�   $��Times New Roman)�6�   $��15(�6�   �� 5*   
   -   5        $ 
txttensach��5*      $
��Left=�6&   #��[ 6A   $��
307,88,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��120��6�   $��Times New Roman)�6�   $��15(�6�   �� 5+   
   -   5        $ 
txtsotrang��5+      $
��Left=�6&   #��[ 6A   $��307,175,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��120��6�   $��Times New Roman)�6�   $��15(�6�   �� 5,   
   -	   5         ��Name$ cbnxb��5,      $
��Left=�6"   #��[ 6=   $��307,129,0,0q�6Z   $	��Top=�6o   $	��120��6�   5.      &   System.Windows.Controls.DataGrid  5/   
   -
   5        	  Name$	 dtg_sach��5/      $��86,258,85,0q�6&   
   CanUserAddRows$
 False��6;      AutoGenerateColumns$ False��6R   $	��131��6n   $	��Top=�6{   $��Times New Roman)�6�   $��15(�6�    50      ��%V   '        �� 51      "  6   .�52      ��  � ��$ Center=�6C   53      54         Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Masach+6Q     57      $ 
Tên sách��6%   $ * 6S    67   �� *	Tensach+6S     58      $ Mã nxb��6%   $ * 6O    65   �� *Manxb+6O     59      $ 
Số trang��6%   $ * 6S    67   �� *	Sotrang+6S     5:      $ Thành tiền��6%   $ * 6W    69   �� *	thanhtien+6W   5<      5=      5>      