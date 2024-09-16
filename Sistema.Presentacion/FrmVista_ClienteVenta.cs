using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmVista_ClienteVenta : Form
    {
        //IMPLEMENTA UN DICCIONARIO PARA EL ALMACENAMIENTO DE DATOS PARES DE CLAVE Y VALOR DE HASHMAP
        private Dictionary<int, string> clientes = new Dictionary<int, string>();

        public FrmVista_ClienteVenta()
        {
            InitializeComponent();
        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NPersona.BuscarClientes(TxtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[9].Visible = false;
            DgvListado.Columns[1].Width = 40;
            DgvListado.Columns[1].HeaderText = "ID";
            DgvListado.Columns[2].Width = 100;
            DgvListado.Columns[2].HeaderText = "TIPO DE PERSONA";
            DgvListado.Columns[3].Width = 170;
            DgvListado.Columns[3].HeaderText = "NOMBRE";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "DOCUMENTO";
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "NUMERO DE DOCUMENTO";
            DgvListado.Columns[6].Width = 120;
            DgvListado.Columns[6].HeaderText = "DIRECCION";
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[7].HeaderText = "TELEFONO";
            DgvListado.Columns[8].Width = 120;
            DgvListado.Columns[8].HeaderText = "EMAIL";
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NPersona.ListarClientes();
                this.Formato();
                label1.Text = "TOTAL DE REGISTROS: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CargarClientes()
        {
            // CARGA LOS DATOS REGISTRADOS POR EL FORMULARIO FrmCRUD_Clientes EN EL HASHMAP DE CLIENTES
            foreach (var cliente in FrmCRUD_Clientes.clientes)
            {
                clientes.Add(cliente.Key, cliente.Value);
            }
        }
        //CARGARA EN EL LOAD DE FrmVista_ClienteVenta LOS DATOS REGISTRADOS EN EL FORMULARIO ANTERIOR MENCIONADO
        private void FrmVista_ClienteVenta_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdCliente = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
            Variables.NombreCliente = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
            this.Close();
        }

        private void BtnCRUDClientes_Click(object sender, EventArgs e)
        {
            // AL PRESIONAR EL BOTON CRUD ABRIRA EL FORMULARIO FrmCRUD_Clientes PARA CONTINUAR CON EL PROCEDIMIENTO DE REGISTRO DE CLIENTES CON HASHMAP
            FrmCRUD_Clientes frmClientes = new FrmCRUD_Clientes();
            frmClientes.ShowDialog();
        }
        // SE CREO UN BOTON PARA REFRESCAR EL DATAGRIDVIEW EN CASO DE NO ACTUALIZARSE, NO ES NECESARIO PERO POR SI ACASO
        private void BtnRegrescar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
