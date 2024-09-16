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
    public partial class FrmVista_ProveedorIngreso : Form
    {
        public FrmVista_ProveedorIngreso()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NPersona.ListarProveedores();
                this.Formato();
                label1.Text = "TOTAL DE REGISTROS: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NPersona.BuscarProveedores(TxtBuscar.Text);
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
        private void FrmVista_ProveedorIngreso_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdProveedor = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
            Variables.NombreProveedor = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
            this.Close();
        }
    }
}
