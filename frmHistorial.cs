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
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();

            cmbFiltro.Items.AddRange(new string[] { "Todos", "Motocicleta", "dron", "camion", "Bicileta" });
            cmbFiltro.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = cmbFiltro.SelectedItem.ToString();
                CargarPedidos(filtro);
            }
            catch (Exception)
            {

                throw;
            }


        }


        private void frmHistorial_Load(object sender, EventArgs e)
        {
            try
            {
                cmbFiltro.SelectedIndex = 0;
                CargarPedidos();
                dgvHistorial.ReadOnly = true;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void CargarPedidos(string filtro = "Todos")
        {
            try
            {
                var pedidos = RegistroPedidos.Instancia.Pedidos;
                if (filtro != "Todos")
                    pedidos = pedidos.Where(p => p.MetodoEntrega.TipoEntrega() == filtro).ToList();
                dgvHistorial.DataSource = pedidos
                .Select(p => new
                {
                    Cliente = p.Cliente,
                    Producto = p.Producto,
                    Urgente = p.Urgente,
                    Peso = p.Peso,
                    Distancia = p.Distancia,
                    TipoEntrega = p.MetodoEntrega.TipoEntrega(),
                    Costo = p.ObtenerCosto()
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
              Focus();
                dgvHistorial.ReadOnly = false;

            
            }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }


