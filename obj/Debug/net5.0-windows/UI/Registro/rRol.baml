   M S B A M L   `   `   `  ����M  IRegistroRolDetalle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:RegistroDeOrdenes.UI.RegistroRegistroDeOrdenes.UI.Registro  5   	   (    "RegistroDeOrdenes.UI.Registro.rRol   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:RegistroDeOrdenes.UI.Registro     5   	     � Title$  Registro Rol��5   	   $	��350��6   $	��500��6+   .��5	      � .+�5
   
   �� $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Rol Id: ��6   �� 5      -   5         ��Name$ RolIdTextBox��5      $��20��60   $	��150��6<   $��32,0,0,0q�6_   ��6H   �� *RolId+6_   �� 5      -   5         ��Name$ BuscarButton��5      $	��5,0q�6/   $��20��6<   $��30��6H   5      �� 5      $��90, 7q�6   .+�5      �� -   5         ��Name$ ActivoCheckBox��5      $��Activo��67    d� 	IsChecked 6H   �� *
esActivo+5      5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Descripcion: ��6   �� 5      -   5        $ DescripcionTextBox��5      $��20��66   $	��350��6B   ��6N   �� *Descripcion+5      �� 5      $ Vertical=�6   $
��0,10q�60   .+�5      �� $��0q�6   .+�5       �� $ 
Horizontal=�6!   .+�5!      �� $��Permiso:��6    �� 5"      -   5         ��Name$ PermisosComboBox��5"   #   $	��350��6=   $
��23,0q�6J   $��25��6X   5#      �� 5%      $ 
Horizontal=�6!   $
��0,10q�6:   $��Center=�6H   .+�5&      �� -   5        $ AgregarFilaButton��5&   !   $
��10,0q�6<   $	��100��6j   .��5'      �� $ 
Horizontal=�6)   .+�5(   "   �� $��Agregar fila��6(   5)      5*      �� 5+      -   5        $ RemoverFilaButton��5+   !   $
��10,0q�6<   $	��100��6j   .��5,      �� $ 
Horizontal=�6)   .+�5-   "   �� $��Eliminar fila��6(   5.      5/      50      &   System.Windows.Controls.DataGrid  52      -   5          Name$ DetalleDataGrid��52      $��80��6Y      AutoGenerateColumns$ False��6e   $	��430��6�   ��69   �� *	Detalle+	   Columns	 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Permiso Id��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *	PermisoId+  55      $
 Es Asignado��61    6F   �� *
esAsignado+57      59      5;      �� 5=      $ 
Horizontal=�6   $
��0,15q�62   $��Center=�6@   .+�5?      �� -	   5        $ NuevoButton��5?      $	��5,0q�6.   .��5@      �� $ 
Horizontal=�6!   .+�5B      �� $��Nuevo��6    5C      5D      �� 5E      -
   5        $ GuardarButton��5E      $	��5,0q�62   .��5F      �� $ 
Horizontal=�6!   .+�5H      �� $��Guardar��6    5I      5J      �� 5K      -   5        $ EliminarButton��5K      $	��5,0q�62   .��5L      �� $ 
Horizontal=�6!   .+�5N      �� $��Eliminar��6    5O      5P      5Q      5R      5S      5T      