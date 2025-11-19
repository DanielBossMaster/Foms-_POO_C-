namespace Foms__POO_C.Clases
{
    public class Tienda : Producto
    {
        public Tienda(string nombre, decimal precio) : base(nombre, precio) { }

        public override decimal CalcularDescuento()
        {
            return Precio * 0.95m; // 5% descuento
        }
    }
}
