using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp_WalterBenitez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbProducto.Items.AddRange(new string[] { "Tecnología", "Accesorio", "Componente" });
            cmbProducto.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    MessageBox.Show("El nombre del cliente es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCliente.Focus();
                    return;
                }

                if (cmbProducto.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbProducto.Focus();
                    return;
                }

                if (nudPeso.Value <= 0 || nudDistancia.Value <= 0)
                {
                    MessageBox.Show("Las opciones de distancia y peso deben tener un valor asignado mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudPeso.Focus();
                    return;
                }

                if (nudPeso.Value <= 0)
                {
                    MessageBox.Show("La distancia debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudPeso.Focus();
                    return;
                }

               
                if (nudDistancia.Value <= 0)
                {
                    MessageBox.Show("El Peso debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudDistancia.Focus();
                    return;
                }

                if (cmbProducto.SelectedItem.ToString() == "accesorio" && !chkUrgente.Checked && nudPeso.Value < 2 && nudDistancia.Value > 20)
                {
                    MessageBox.Show("Para envíos en bicicleta la distancia máxima es 20 km", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudDistancia.Focus();
                    return;
                }

                string cliente = txtCliente.Text.Trim();
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nudPeso.Value);
                int distancia = Convert.ToInt32(nudDistancia.Value);

                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(pedido);

                lblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()} \n" +
                                  $"Costo: ${pedido.ObtenerCosto():0.00}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto en alguno de los valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Valor numérico demasiado grande", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    
   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmHistorial().ShowDialog();
        }
        private void LimpiarDatos()
        {
            txtCliente.Clear();
            chkUrgente.Checked = false;
            nudPeso.Value = nudPeso.Minimum;
            nudDistancia.Value = nudDistancia.Minimum;
            lblResultado.Text = string.Empty;
            txtCliente.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
