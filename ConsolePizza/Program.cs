// See https://aka.ms/new-console-template for more information

using ConsolePizza;

Pizza muzzaChica = new Pizza();
muzzaChica.IdProducto = 45;
muzzaChica.Nombre = "Muzzarella Chica";
muzzaChica.Tamaño = "Chica";
muzzaChica.Precio = 10000;

Pizza muzzaMedia = new Pizza();
muzzaMedia.IdProducto = 46;
muzzaMedia.Nombre = "Muzzarella Mediana";
muzzaMedia.Tamaño = "Mediana";
muzzaMedia.Precio = 15000;

Pizza muzzaGrande = new Pizza();
muzzaGrande.IdProducto = 47;
muzzaGrande.Nombre = "Muzzarella Grande";
muzzaGrande.Tamaño = "Grande";
muzzaGrande.Precio = 18000;

ItemPedido item = new ItemPedido();
item.Producto = muzzaChica;
item.Cantidad = 4;

DetallePedido detalle = new DetallePedido();
detalle.AgregarItemPedido(item);

List<ItemPedido> items = detalle.ListarItems();

foreach (ItemPedido itemL in items)
{
    Console.WriteLine(item.Producto.Nombre);
}





