namespace Foms__POO_C.Clases
{
    public class Producto
    {
        // Propiedades encapsuladas
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Constructor
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        // Método virtual (polimorfismo)
        public virtual decimal CalcularDescuento()
        {
            // Descuento general del 5 %
            return Precio * 0.95m;
        }
    }
}
