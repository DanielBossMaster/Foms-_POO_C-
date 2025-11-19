using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foms__POO_C_.Clases;


namespace Foms__POO_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Tecnología");
            cmbTipo.Items.Add("Comida");
            cmbTipo.Items.Add("Tienda");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar nombre
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar precio
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido (mayor que 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar tipo
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear el producto según tipo
            Producto producto;

            switch (cmbTipo.SelectedItem.ToString())
            {
                case "Tecnología":
                    producto = new Tecnologia(nombre, precio);
                    break;
                case "Comida":
                    producto = new Comida(nombre, precio);
                    break;
                default:
                    producto = new Tienda(nombre, precio);
                    break;
            }

            // Calcular y mostrar el valor final con formato de moneda
            decimal precioFinal = producto.CalcularDescuento();
            lblResultado.Text = $"Precio final con descuento: {precioFinal:C}";
        }
    }
}
