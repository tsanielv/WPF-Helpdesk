   M S B A M L   `   `   `  ����C  ?HelpDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HelpDesk.ViewsHelpDesk.Views  5   	       HelpDesk.Views.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:HelpDesk.Views     5   	   -   5          � Title$  Helpdesk System��5   	   $��682.722��6!   $��2135.126��62   .��5	      � .+�5   
   �� .@�5      �� $�� Data User ��6   .��5      � $��10q�6   .+�5      � ���#5F9EA0$
��Left=�60   $	��929��6K   $��-11,-10,0,-638q�6X   $	��Top=�6p   $	��935��6�    � ColumnDefinitions 5      �� 5      $
��153* �6/   �� 5      $
��164* �6/   �� 5      $
��618* �6/   .+�5      �� -   5         ��Name$ label5��5       $��	DATA USER��60   $
��Left=�6D   $��
147,10,0,0q�6_   $	��Top=�6s   $��16(�6�   $
��Bold"�6�   
�������$��2��6�   �� 5      -   5        $ label6��5       $��User Id��60   $
��Left=�6B   $��	10,50,0,0q�6]   $	��Top=�6p   $��14.667(�6�   
�������6�   �� 5      -   5        $ label7��5       $��
First Name��60   $
��Left=�6E   $��	10,85,0,0q�6`   $	��Top=�6s   $��14.667(�6�   
�������6�   �� 5      -   5        $ label8��5       $��	Last Name��60   $
��Left=�6D   $��
10,120,0,0q�6_   $	��Top=�6s   $��14.667(�6�   
�������6�   �� 5      -   5        $ label9��5       $��Username��60   $
��Left=�6C   $��
10,155,0,0q�6^   $	��Top=�6r   $��14.667(�6�   
�������6�   �� 5      -   5        $ label10��5       $��Password��61   $
��Left=�6D   $��
10,190,0,0q�6_   $	��Top=�6s   $��14.667(�6�   
�������6�   �� 5      -   5        $ label11��5       $��Address��61   $
��Left=�6C   $��
10,225,0,0q�6^   $	��Top=�6r   $��14.667(�6�   
�������6�   �� 5      -	   5        $ label12��5       $
��City��61   $
��Left=�6@   $��
15,290,0,0q�6[   $	��Top=�6o   $��14.667(�6�   
�������6�   �� 5      -
   5        $ label13��5       $��Phone��61   $
��Left=�6A   $��
15,330,0,0q�6\   $	��Top=�6p   $��14.667(�6�   
�������6�   �� 5      -   5        $ label14��5       $��Email��61   $
��Left=�6A   $��
12,365,0,0q�6\   $	��Top=�6p   $��14.667(�6�   
�������6�   �� 5      -   5        $ label15��5       $��
Department��61   $
��Left=�6F   $��
10,400,0,0q�6a   $	��Top=�6u   $��14.667(�6�   
�������6�   �� 5      -   5        $ label16��5       $
��Role��61   $
��Left=�6@   $��
12,435,0,0q�6[   $	��Top=�6o   $��14.667(�6�   
�������6�   �� 5       -   5         ��Name$ tb_u_id��5    "   $
��Left=�63   $��27��6N   $��
123,56,0,0q�6Z    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��120��6�    J� RenderTransformOrigin$ 0,-1.739&�6�   $��2��6�    �� 
IsReadOnly . 6�   �� 5!      -   5        $ tb_u_firstName��5!   "   $
��Left=�6:   $��27��6U   $��
123,91,0,0q�6a   $
 Wrap=�6u   $	��Top=�6�   $	��256��6�   $��3��6�   �� 5"      -   5        $ tb_u_lastName��5"   "   $
��Left=�69   $��27��6T   $��123,127,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��256��6�   $��3��6�   �� 5#      -   5        $ tb_u_username��5#   "   $
��Left=�69   $��27��6T   $��123,161,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��256��6�   $��3��6�   �� 5$      -   5        $ tb_u_password��5$   "   $
��Left=�69   $��27��6T   $��123,195,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��256��6�   $��3��6�   �� 5%      -   5        $ tb_u_address��5%   "   $
��Left=�68   $��56��6S   $��123,232,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��256��6�   $��3��6�   �� 5&      -   5        $ 	tb_u_city��5&   "   $
��Left=�65   $��27��6P   $��123,297,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��256��6�   $��3��6�   �� 5'      -   5        $ 
tb_u_phone��5'   "   $
��Left=�6a   $��27��6|   $��123,333,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��256��6�   $��3��6�   �� 5(      -   5        $ 
tb_u_email��5(   "   $
��Left=�66   $��27��6Q   $��123,369,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��256��6�   $��3��6�   �� 5)      -   5         ��Name$ btnSave��5)   !   $
��Save��62   $
��Left=�6A   $��123,489,0,0q�6\   $	��Top=�6q   $��62��6�   $��2��6�   $��31��6�   $��14.667(�6�   6�   �� 5*      -   5        $ btnEdit��5*   !   $��Update��62   $��1��6C   $
��Left=�6S   $��
48,489,0,0q�6n   $	��Top=�6�   $��75��6�   $��31��6�   $��14.667(�6�   6�   �� 5+      -   5        $ 	btnDelete��5+   !   $��Delete��64   $��1��6E   $
��Left=�6U   $��139,489,0,0q�6p   $	��Top=�6�   $��77��6�   $��33��6�   $��14.667(�6�   $��2��6�   6�   �� 5,      -   5         ��Name$ cb_u_departmentid��5,   #   $��3��6>   $
��Left=�6R   $��123,408,0,0q�6m   $	��Top=�6�   $	��256��6�   $��27��6�   �� 5-      -   5        $ cb_u_roleid��5-   #   $��3��68   $
��Left=�6L   $��123,443,0,0q�6g   $	��Top=�6|   $	��256��6�   $��27��6�   5/      &   System.Windows.Controls.DataGrid  50      -   5        $��dgUser��50      	   AutoGenerateColumns	 .  $��383,-10,-10,-13q�6I   
   Columns
 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$
  ID ��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+6V     53      $  First Name ��61   $	 150 6f    6G   �� *
First_Name+6f     54      $  Last Name ��61   $	 150 6d    6F   �� *	Last_Name+6d     55      $ 
 Username ��61   $	 100 6b    6E   �� *
Username+6b     56      $ 
 Password ��61   $	 100 6b    6E   �� *
Password+6b     57      $ 	 Address ��61   $	 150 6`    6D   �� *	Address+6`     58      $  City ��61   $	 100 6Z    6A   �� *City+6Z     59      $  Phone ��61   $	 100 6\    6B   �� *Phone+6\     5:      $  Email ��61   $	 100 6\    6B   �� *Email+6\     5;      $  Department ��61   $	 100 6v    6G   �� *Department.Department_Name+6v     5<      $  Role ��61   $ 50 6`    6A   �� *
Role.Role1+6`   5>      5A      5E      �� 5F      $�� Data Department ��6   .��5G      � $��
10,8,10,12q�6   .+�5H      � ���#5F9EA0$
��Left=�60   $	��929��6K   $��-11,-10,0,-638q�6X   $	��Top=�6p   $	��935��6�   .+�5I      �� -   5        $ label1��5I       $��DATA DEPARTMENT��60   $
��Left=�6J   $��
107,23,0,0q�6e   $	��Top=�6y   $��16(�6�   $
��Bold"�6�   
�������6�   �� 5J      -   5        $ label2��5J       $��Department ID��60   $
��Left=�6H   $��	12,85,0,0q�6c   $	��Top=�6v   $��14.667(�6�   
�������6�   �� 5K      -   5        $ label3��5K       $��Depeartment Name��60   $
��Left=�6K   $��
12,135,0,0q�6f   $	��Top=�6z   $��14.667(�6�   
�������6�   �� 5L      -    5        $ tb_d_id��5L   "   $
��Left=�63   $��30��6N   $��
164,88,0,0q�6Z   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��120��6�    . 6�   �� 5M      -!   5        $ tb_d_namedepartment��5M   "   $
��Left=�6?   $��30��6Z   $��164,135,0,0q�6f   $
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��201��6�   �� 5N      -"   5        $ button_edit��5N   !   $��Update��66   $
��Left=�6G   $��226,187,0,0q�6b   $	��Top=�6w   $��58��6�   $��27��6�   6�   �� 5O      -#   5        $ button_delete��5O   !   $��Delete��68   $
��Left=�6I   $��290,187,0,0q�6d   $	��Top=�6y   $��75��6�   $��27��6�   6�   �� 5P      -$   5        $ 
button_add��5P   !   $
��Save��65   $
��Left=�6D   $��164,187,0,0q�6_   $	��Top=�6t   $��57��6�   $��27��6�   6�   5Q        5S      -%   5        $��dgDepartment��5S      	 .  $��363,-10,-366,-16q�6P   
 5T        5U      $ ID��61   $	 100 6=    6I   �� *Id+  5V      $ Department Name��61   $	 250 6J    6V   �� *Department_Name+   RowDetailsTemplate 5X      �� 5Y      .R�5Z   "   �� $��10q�6E   ��6,   �� *	Details+6E   5[      5]      5a      5b      �� 5c      $�� Data Role ��6   .��5d      � $��
10,8,10,12q�6   .+�5e      � ���#5F9EA0$
��Left=�60   $	��929��6K   $��-11,-10,0,-638q�6X   $	��Top=�6p   $	��935��6�    5f      �� 5g      $��9* �6/   �� 5h      $	��46* �6/   .+�5j      �� -&   5        $ label_titlerole��5j       $��	DATA ROLE��69   $
��Left=�6M   $��
133,23,0,0q�6h   $	��Top=�6|   $��16(�6�   $
��Bold"�6�   
�������$��2��6�   �� 5k      -'   5        $ label��5k       $��Role ID��6/   $
��Left=�6A   $��	10,77,0,0q�6\   $	��Top=�6o   
�������$��14.667(�6�   �� 5l      -(   5        $ label4��5l       $��	Role Name��60   $
��Left=�6D   $��
10,125,0,0q�6_   $	��Top=�6s   
�������$��14.667(�6�   �� 5m      -)   5        $ tb_r_id��5m   "   $
��Left=�63   $��32��6N   $��
107,77,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   $��2��6�    . 6�   �� 5n      -*   5        $ tb_r_namerole��5n   "   $
��Left=�69   $��34��6T   $��107,125,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��251��6�   $��2��6�   �� 5o      -+   5        $ btn_save��5o   !   $
��Save��63   $
��Left=�6B   $��107,187,0,0q�6]   $	��Top=�6r   $��69��6�   $��31��6�   $��2��6�   �� 5p      -,   5        $ btn_edit��5p   !   $��Update��63   $
��Left=�6D   $��
35,188,0,0q�6_   $	��Top=�6s   $��75��6�   $��31��6�   $��1��6�   6�   �� 5q      --   5        $ 
btn_delete��5q   !   $��Delete��65   $
��Left=�6F   $��127,188,0,0q�6a   $	��Top=�6v   $��75��6�   $��31��6�   $��1��6�   6�   5r        5t      -.   5        $��dgRole��5t      	 .  $��362,-10,-365,-16q�6J   
 5u        5v      $ ID��61   $	 100 6=    6I   �� *Id+  5w      $ 	Role Name��61   $	 250 6D    6P   �� *Role1+ 5y      �� 5z      .R�5{   "   �� $��10q�6E   ��6,   �� *	Details+6E   5|      5~      5�      5�      �� 5�      $�� Data Category��6   .��5�      � $��
10,8,10,12q�6   .+�5�      � ���#5F9EA0$
��Left=�60   $	��929��6K   $��-11,-10,0,-638q�6X   $	��Top=�6p   $	��935��6�    5�      �� 5�      $��9* �6/   �� 5�      $	��46* �6/   .+�5�      �� -/   5        $ label_titlecategory��5�       $��DATA CATEGORY��6=   $
��Left=�6U   $��
107,23,0,0q�6p   $	��Top=�6�   $��16(�6�   $
��Bold"�6�   
�������$��2��6�   �� 5�      -0   5        $ label_idcategory��5�       $��Category ID��6:   $
��Left=�6P   $��	10,77,0,0q�6k   $	��Top=�6~   
�������$��14.667(�6�   �� 5�      -1   5        $ label_cname��5�       $��Category Name��65   $
��Left=�6M   $��
10,125,0,0q�6h   $	��Top=�6|   
�������$��14.667(�6�   �� 5�      -2   5        $ tb_c_id��5�   "   $
��Left=�63   $��32��6N   $��
126,77,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   $��2��6�    . 6�   �� 5�      -3   5        $ tb_c_categoryname��5�   "   $
��Left=�6=   $��34��6X   $��126,125,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��232��6�   $��2��6�   �� 5�      -4   5        $ 
btn_c_save��5�   !   $
��Save��65   $
��Left=�6D   $��107,187,0,0q�6_   $	��Top=�6t   $��69��6�   $��31��6�   $��2��6�   6�   �� 5�      -5   5        $ 
btn_c_edit��5�   !   $��Update��65   $
��Left=�6F   $��
35,188,0,0q�6a   $	��Top=�6u   $��75��6�   $��31��6�   $��1��6�   6�   �� 5�      -6   5        $ btn_c_delete��5�   !   $��Delete��67   $
��Left=�6H   $��127,188,0,0q�6c   $	��Top=�6x   $��75��6�   $��31��6�   $��1��6�   6�   5�        5�      -7   5        $��
dgCategory��5�      	 .  $��362,-10,-365,-16q�6N   
 5�        5�      $ ID��61   $	 100 6T    6=   �� *Id+6T     5�      $ Category Name��61   $	 250 6j    6H   �� *Category_Name+6j    5�      �� 5�      .R�5�   "   �� $��10q�6E   ��6,   �� *	Details+6E   5�      5�      5�      5�      �� 5�      $�� Data Sub Catgory ��6   .��5�      � $��
10,8,10,12q�6   .+�5�      � ���#5F9EA0$
��Left=�60   $	��929��6K   $��-11,-10,0,-638q�6X   $	��Top=�6p   $	��935��6�    5�      �� 5�      $��9* �6/   �� 5�      $	��46* �6/   .+�5�      �� -8   5        $ label17��5�       $��SUB CATEGORY��61   $
��Left=�6H   $��
112,22,0,0q�6c   $	��Top=�6w   $
��Bold"�6�   $��16(�6�   
�������$��2��6�   �� 5�      -9   5        $ label18��5�       $��ID SUB��61   $
��Left=�6B   $��	10,70,0,0q�6]   $	��Top=�6p   $��14.667(�6�   
�������6�   �� 5�      -:   5        $ label18_Copy��5�       $��SUB CATEGORY��66   $
��Left=�6M   $��
10,117,0,0q�6h   $	��Top=�6|   $��14.667(�6�   
�������6�   �� 5�      -;   5        $ label18_Copy1��5�       $��CATEGORY��67   $
��Left=�6J   $��
10,164,0,0q�6e   $	��Top=�6y   $��14.667(�6�   
�������6�   �� 5�      -<   5        $ tb_sc_id��5�   "   $
��Left=�64   $��30��6O   $��
132,70,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��107��6�   $��2��6�    . 6�   �� 5�      -=   5        $ tb_sc_subcategoryname��5�   "   $
��Left=�6A   $��30��6\   $��132,117,0,0q�6h   $
 Wrap=�6}   $	��Top=�6�   $	��229��6�   $��2��6�   �� 5�      ->   5        $ cb_sc_categoriid��5�   #   $
��Left=�6=   $��132,164,0,0q�6X   $	��Top=�6m   $	��229��6�   $��2��6�   $��30��6�   �� 5�      -?   5        $ btn_sc_save��5�   !   $
��Save��66   $
��Left=�6E   $��132,214,0,0q�6`   $	��Top=�6u   $��56��6�   $��2��6�   $��30��6�   6�   �� 5�      -@   5        $ btn_sc_edit��5�   !   $��Update��66   $
��Left=�6G   $��
40,214,0,0q�6b   $	��Top=�6v   $��69��6�   $��30��6�   $��1��6�   6�   �� 5�      -A   5        $ btn_sc_delete��5�   !   $��Delete��68   $
��Left=�6I   $��114,214,0,0q�6d   $	��Top=�6y   $��78��6�   $��30��6�   $��1��6�   6�   5�        5�      -B   5        $��dgSubCategory��5�      	 .  $��362,-10,-365,-16q�6Q   
 5�        5�      $ ID��61   $	 100 6T    6=   �� *Id+6T     5�      $ Sub Category Name��61   $	 250 6q    6L   �� *SubCategory_Name+6q     5�      $ Category��61   $	 250 6n    6C   �� *Category.Category_Name+6n    5�      �� 5�      .R�5�   "   �� $��10q�6E   ��6,   �� *	Details+6E   5�      5�      5�      5�      �� 5�      $�� Data Type ��6   .��5�      � $��
10,8,10,12q�6   .+�5�      � ���#5F9EA0$
��Left=�60   $	��929��6K   $��-11,-10,0,-638q�6X   $	��Top=�6p   $	��935��6�    5�      �� 5�      $��9* �6/   �� 5�      $	��46* �6/   .+�5�      �� -C   5        $ label19��5�       $��DATA TYPE / DUE DATE��61   $
��Left=�6P   $��
106,21,0,0q�6k   $	��Top=�6   $��2��6�   $
��Bold"�6�   $��14.667(�6�   
�������6�   �� 5�      -D   5        $ label20��5�       $
��Type��61   $
��Left=�6@   $��	10,77,0,0q�6[   $	��Top=�6n   $��14.667(�6�   
�������6�   �� 5�      -E   5        $ label20_Copy��5�       $��Interval��66   $
��Left=�6I   $��
10,120,0,0q�6d   $	��Top=�6x   $��14.667(�6�   
�������6�   �� 5�      -F   5        $ 	cb_t_type��5�   #   $
��Left=�66   $��
106,82,0,0q�6Q   $	��Top=�6e   $	��171��6}   $��2��6�   $��27��6�   .@�5�      �� -G   5        $	��Low��5�   +   $	��Low��66   6F   �� 5�      -H   5        $��Medium��5�   +   $��Medium��69   6L   �� 5�      -I   5        $
��High��5�   +   $
��High��67   6H   5�      �� 5�      -J   5        $ tb_t_interval��5�   "   $
��Left=�6d   $��27��6   $��106,127,0,0q�6�   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��171��6�   $��2��6�   �� 5�      -K   5        $ 
btn_t_save��5�   !   $	��Add��65   $
��Left=�6C   $��106,173,0,0q�6^   $	��Top=�6s   $��63��6�   $��2��6�   $��27��6�   6�   �� 5�      -L   5        $ 
btn_t_edit��5�   !   $��Update��65   $
��Left=�6F   $��
32,173,0,0q�6a   $	��Top=�6u   $��63��6�   $��27��6�   $��1��6�   6�   �� 5�      -M   5        $ btn_t_delete��5�   !   $��Delete��67   $
��Left=�6H   $��113,173,0,0q�6c   $	��Top=�6x   $��63��6�   $��27��6�   $��1��6�   6�   5�        5�      -N   5        $��dgType��5�      	 .  $��362,-10,-365,-16q�6J   
 5�        5�      $ 	Type Name��61   $	 100 6]    6D   �� *Type+6]     5�      $ Interval��61   $	 250 6`    6C   �� *
Interval+6`    5�      �� 5�      .R�5�   "   �� $��10q�6E   ��6,   �� *	Details+6E   5�      5�      5�      5�      �� 5�      $�� Data Ticket ��6   .��5�      � $��
10,8,10,12q�6   .+�5�      � ���#5F9EA0$
��Left=�60   $	��929��6K   $��-11,-10,0,-638q�6X   $	��Top=�6p   $	��935��6�    5�      �� 5�      $��9* �6/   �� 5�      $	��46* �6/   .+�5�      �� -O   5        $ label_titleticket��5�       $��INSERT TICKET��6;   $
��Left=�6S   $��
134,10,0,0q�6n   $	��Top=�6�   $��16(�6�   $
��Bold"�6�   
�������$��2��6�   �� 5�      -P   5        $ label_ttype��5�       $
��Type��65   $
��Left=�6D   $��	10,40,0,0q�6_   $	��Top=�6r   $��14.667(�6�   
�������6�   �� 5�      -Q   5        $ label_tdescription��5�       $��Problems��6<   $
��Left=�6O   $��	10,75,0,0q�6j   $	��Top=�6}   $��14.667(�6�   
�������6�   �� 5�      -R   5        $ 
label_tdtm��5�       $��Date Create��64   $
��Left=�6J   $��
10,110,0,0q�6e   $	��Top=�6y   $��14.667(�6�   
�������6�   �� 5�      -S   5        $ 	label_tl1��5�       $��Admin��63   $
��Left=�6C   $��
10,145,0,0q�6^   $	��Top=�6r   $��14.667(�6�   
�������6�   �� 5�      -T   5        $ 
label_tdue��5�       $��Due Date��64   $
��Left=�6G   $��
10,180,0,0q�6b   $	��Top=�6v   $��14.667(�6�   
�������6�   �� 5�      -U   5        $ label_tlast��5�       $��Last Update��65   $
��Left=�6K   $��
10,215,0,0q�6f   $	��Top=�6z   $��14.667(�6�   
�������6�   �� 5�      -V   5        $ label_tonprog��5�       $��Date On Progress��67   $
��Left=�6R   $��
10,250,0,0q�6m   $	��Top=�6�   $��14.667(�6�   
�������6�   �� 5�      -W   5        $ label_tonwait��5�       $��Date On Wait��67   $
��Left=�6N   $��
10,285,0,0q�6i   $	��Top=�6}   $��14.667(�6�   
�������6�   �� 5�      -X   5        $ label_tonhold��5�       $��Date On Hold��67   $
��Left=�6N   $��
10,320,0,0q�6i   $	��Top=�6}   $��14.667(�6�   
�������6�   �� 5�      -Y   5        $ label_tresolved��5�       $��Resolved Time��69   $
��Left=�6Q   $��
10,355,0,0q�6l   $	��Top=�6�   $��14.667(�6�   
�������6�   �� 5�      -Z   5        $ label_tclosed��5�       $��Closed Time��67   $
��Left=�6M   $��
10,390,0,0q�6h   $	��Top=�6|   $��14.667(�6�   
�������6�   �� 5�      -[   5        $ label_ttechnician��5�       $��
Technician��6;   $
��Left=�6P   $��
10,425,0,0q�6k   $	��Top=�6   $��14.667(�6�   
�������6�   �� 5      -\   5        $ label_tstatus��5       $��Status��67   $
��Left=�6H   $��
10,460,0,0q�6c   $	��Top=�6w   $��14.667(�6�   
�������6�   �� 5     -]   5        $ label_tuserid��5      $
��User��67   $
��Left=�6F   $��
10,495,0,0q�6a   $	��Top=�6u   $��14.667(�6�   
�������6�   �� 5     -^   5        $ label_tcategoryid��5      $��Category��6;   $
��Left=�6N   $��
10,530,0,0q�6i   $	��Top=�6}   $��14.667(�6�   
�������6�   �� 5     -_   5        $ label_tsubcategoryid��5      $��Sub Category��6>   $
��Left=�6U   $��
10,565,0,0q�6p   $	��Top=�6�   $��14.667(�6�   
�������6�   �� 5     -`   5        $ tb_tk_description��5  "   $
��Left=�6=   $��27��6X   $��3,75,0,0q�6d   $
 Wrap=�6v   $	��Top=�6�   $	��202��6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5     -a   5          Name$ dp_datecreate��5  %   $��1��6<   $
��Left=�6L   $��	3,110,0,0q�6g   $	��Top=�6z   $��27��6�   $	��202��6�   {�.  6�     5     -b   5        $ 
dp_duedate��5  %   $��1��69   $
��Left=�6I   $��	0,180,0,0q�6d   $	��Top=�6w   $��27��6�   $	��205��6�   {�.  6�     5	     -c   5        $ dp_lastupdate��5	  %   $��1��6<   $
��Left=�6L   $��	0,215,0,0q�6g   $	��Top=�6z   $��27��6�   $	��205��6�   {�.  6�     5
     -d   5        $ dp_onprogress��5
  %   $��1��6<   $
��Left=�6L   $��	0,250,0,0q�6g   $	��Top=�6z   $��27��6�   $	��205��6�   {�.  6�     5     -e   5        $ 	dp_onwait��5  %   $��1��68   $
��Left=�6H   $��	0,285,0,0q�6c   $	��Top=�6v   $��27��6�   $	��205��6�   {�.  6�     5     -f   5        $ 	dp_onhold��5  %   $��1��68   $
��Left=�6H   $��	0,320,0,0q�6c   $	��Top=�6v   $��27��6�   $	��205��6�   {�.  6�     5     -g   5        $ dp_resolved��5  %   $��1��6:   $
��Left=�6J   $��	0,355,0,0q�6e   $	��Top=�6x   $��27��6�   $	��205��6�   {�.  6�     5     -h   5        $ 	dp_closed��5  %   $��1��68   $
��Left=�6H   $��	0,390,0,0q�6c   $	��Top=�6v   $��27��6�   $	��205��6�   {�.  6�   �� 5     -i   5        $ 
cb_tk_user��5  #   $��1��67   $
��Left=�6G   $��	3,495,0,0q�6b   $	��Top=�6u   $	��202��6�   $��27��6�   �� 5     -j   5        $ cb_tk_category��5  #   $��1��6;   $
��Left=�6K   $��	3,530,0,0q�6f   $	��Top=�6y   $	��202��6�   $��27��6�   �� 5     -k   5        $ cb_tk_subcategory��5  #   $��1��6>   $
��Left=�6N   $��	3,565,0,0q�6i   $	��Top=�6|   $	��202��6�   $��27��6�   �� 5     -l   5        $ btn_tk_save��5  !   $
��Save��66   $
��Left=�6E   $��	2,597,0,0q�6`   $	��Top=�6s   $��52��6�   $��31��6�   $��14.667(�6�   $��1��6�   6�   �� 5     -m   5        $ btn_tk_edit��5  !   $��Update��66   $
��Left=�6G   $��
67,597,0,0q�6b   $	��Top=�6v   $��62��6�   $��31��6�   $��14.667(�6�   $��1��6�   6�   �� 5     -n   5        $ btn_tk_delete��5  !   $��Delete��68   $
��Left=�6I   $��142,597,0,0q�6d   $	��Top=�6y   $��63��6�   $��31��6�   $��14.667(�6�   $��1��6�   6�   �� 5     -o   5        $ cb_tk_status��5  #   $��1��69   $
��Left=�6I   $��	3,460,0,0q�6d   $	��Top=�6w   $	��202��6�   $��27��6�   .@�5     �� -p   5        $��Laporan_Diterima��5  +   $��Laporan Diterima��6C   6`   �� 5     -q   5        $��
OnProgress��5  +   $��
OnProgress��6=   6T   �� 5     -r   5        $��
OnWaitting��5  +   $��
OnWaitting��6=   6T   �� 5     -s   5        $��	OnHolding��5  +   $��	OnHolding��6<   6R   �� 5      -t   5        $��Resolved��5   +   $��Resolved��6;   6P   �� 5!     -u   5        $��Closed��5!  +   $��Closed��69   6L   5"     �� 5#     -v   5        $ 
cb_tk_type��5#  #   $��1��67   $
��Left=�6G   $��3,40,0,0q�6b   $	��Top=�6t   $	��202��6�   $��27��6�   5%     �� 5&     -w   5        $ cb_tk_l1��5&  #   $��1��65   $
��Left=�6E   $��	3,145,0,0q�6`   $	��Top=�6s   $	��202��6�   $��27��6�   �� 5'     -x   5        $ cb_tk_teknisi��5'  #   $��1��6:   $
��Left=�6J   $��	3,425,0,0q�6e   $	��Top=�6x   $	��202��6�   $��27��6�   5,       5.     -y   5        $��dgTiket��5.     	 .  $��362,-10,-365,-16q�6K   
 5/       50     $ ID��61   $	 100 6T    6=   �� *Id+6T     51     $ 	Type Name��61   $	 100 6]    6D   �� *Type+6]     52     $ Description��61   $	 250 6f    6F   �� *Description+6f     53     $ Date Create��61   $	 100 6b    6F   �� *	Dtm_Crt+6b     54     $ Admin��61   $	 100 6W    6@   �� *L1+6W     55     $ Due Date��61   $	 100 6_    6C   �� *	DueDate+6_     56     $ Last Update��61   $	 100 6f    6F   �� *Last_Update+6f     57     $ Date On Progress��61   $	 100 6n    6K   �� *OnProgressDate+6n     58     $ Date On Wait��61   $	 100 6i    6G   �� *OnWaitingDate+6i     59     $ Date On Hold��61   $	 100 6f    6G   �� *
OnHoldDate+6f     5:     $ Resolved Time��61   $	 100 6i    6H   �� *ResolvedTime+6i     5;     $ Closed Time��61   $	 100 6e    6F   �� *
ClosedTime+6e     5<     $ 
Technician��61   $	 100 6d    6E   �� *
Technician+6d     5=     $ Status��61   $	 100 6\    6A   �� *Status+6\     5>     $
 User��61   $	 100 6Z    6?   �� *UserId+6Z     5?     $ Category��61   $	 100 6b    6C   �� *
CategoryId+6b     5@     $ Sub Category��61   $	 100 6i    6G   �� *SubCategoryId+6i    5C     �� 5D     .R�5E  "   �� $��10q�6E   ��6,   �� *	Details+6E   5F     5H     5I     5J     5L     5N     5O     