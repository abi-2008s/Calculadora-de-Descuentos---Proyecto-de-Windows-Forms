using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_de_Descuentos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // (1) VALIDACIONES
            //revisa si los campos no estan vacíos y que sean numeros positivos

            if (!decimal.TryParse(txtPrecio.Text, out decimal precioOriginal) ||
                !decimal.TryParse(txtMontoTotal.Text, out decimal montoTotal) ||
                precioOriginal <= 0 || montoTotal <= 0)

            {

                MessageBox.Show("Por favor, ingrese números positivos válidos!"); //mensaje de error
                return; //detiene la ejecuación si hay error
            }

            //validación de que se seleccionó algo en el combo

            if (cmbCategoria.SelectedIndex == -1)
            {

                MessageBox.Show("Seleccione una categoría");
                return;
            }

            // (2) LOGICA DE CATEGORIAS usando switch case 

            string categoria = cmbCategoria.SelectedItem.ToString();
            decimal porcentajeDescuento = 0;
            decimal montoMinimoRequerido = 0;

            switch (categoria) {

                case "Electrónica":
                    porcentajeDescuento = 0.10m; //10%
                    montoMinimoRequerido = 500;
                    break;
                case "Ropa":
                    porcentajeDescuento = 0.15m; // 15%
                    montoMinimoRequerido = 300;  // Mayor a $300
                    break;
                case "Alimentos":
                    porcentajeDescuento = 0.05m; // 5%
                    montoMinimoRequerido = 200;   // Mayor a $200
                    break;
                case "Hogar":
                    porcentajeDescuento = 0.20m; // 20%
                    montoMinimoRequerido = 400;   // Mayor a $400
                    break;

            }
            // --- 3. APLICACIÓN DEL DESCUENTO (Uso de If-Else) ---
            decimal precioFinal;
            string mensajeResultado;

            if (montoTotal > montoMinimoRequerido)
            {
                // Se aplica el descuento
                decimal ahorro = precioOriginal * porcentajeDescuento;
                precioFinal = precioOriginal - ahorro;
                mensajeResultado =
                    $"════════════════════════════════════════════" +
                    $"\nSe aplicó un descuento del {porcentajeDescuento * 100}% (${ahorro:N2})." +
                    $"\n════════════════════════════════════════════";
            }
            else
            {
                // No cumple la condición de monto total
                precioFinal = precioOriginal;
                mensajeResultado =
                    $"════════════════════════════════════════════" +
                    $"\nNo se aplicó descuento. El monto total debe ser mayor a ${montoMinimoRequerido}." +
                    $"\n════════════════════════════════════════════";
            }

            // --- 4. SALIDA DE RESULTADOS 
            lblPrecioFinal.Text =
                "≪≪≪≪≪≪≪≫≫≫≫≫≫≫" +
                "\nPrecio Final: $" + precioFinal.ToString("N2") +
                "\n≪≪≪≪≪≪≪≫≫≫≫≫≫≫";
            lblMensaje.Text = mensajeResultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecioFinal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}

































































































































