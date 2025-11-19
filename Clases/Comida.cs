namespace Foms__POO_C.Clases
{
    public class Comida : Producto
    {
        public Comida(string nombre, decimal precio) : base(nombre, precio) { }

        public override decimal CalcularDescuento()
        {
            return Precio * 0.98m; // 2% descuento
        }
    }
}
