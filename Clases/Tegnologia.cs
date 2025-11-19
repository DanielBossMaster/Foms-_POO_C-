namespace Foms__POO_C.Clases
{
    public class Tecnologia : Producto
    {
        public Tecnologia(string nombre, decimal precio) : base(nombre, precio) { }

        // Polimorfismo: redefine el comportamiento
        public override decimal CalcularDescuento()
        {
            return Precio * 0.90m; // 10% descuento
        }
    }
}
