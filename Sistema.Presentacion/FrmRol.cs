using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmRol : Form
    {
        //LA IMPLEMENTACION DE SORTEDSET
        SortedSet<string> sortedSet = new SortedSet<string>();
        public FrmRol()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NRol.Listar();
                this.Formato();
                label1.Text = "TOTAL DE REGISTROS: " + Convert.ToString(DgvListado.Rows.Count);

                // AQUI IMPLEMENTE UN FOREACH PARA QUE RECORRA EL DATAGRIDVIEW Y ALMANCENE LOS VALORES QUE CONTIENE LA COLUMNA 2
                sortedSet = new SortedSet<string>();
                foreach (DataGridViewRow row in DgvListado.Rows)
                {
                    string nombreCategoria = Convert.ToString(row.Cells[2].Value);
                    sortedSet.Add(nombreCategoria);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[1].Width = 40;
            DgvListado.Columns[1].HeaderText = "ID";
            DgvListado.Columns[2].Width = 1700;
            DgvListado.Columns[2].HeaderText = "TIPOS DE ACCESOS";
        }
        private void FrmRol_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        // CREE UN BOTON PARA ORDENAR ASCENDENTEMENTE LOS ELEMENTOS Y MOSTRARLOS DENTRO DE UN FOR EN EL DGVLISTADO
        private void BtnOrdenarAscendente_Click(object sender, EventArgs e)
        {
            List<string> elementosOrdenados = sortedSet.ToList();

            for (int i = 0; i < elementosOrdenados.Count; i++)
            {
                DgvListado.Rows[i].Cells[2].Value = elementosOrdenados[i];
            }
        }
        // CREE UN BOTON PARA ORDENAR DESCENDENTEMENTE LOS ELEMENTOS Y MOSTRARLOS DENTRO DE UN FOR EN EL DGVLISTADO
        private void BtnOrdenarDescendente_Click(object sender, EventArgs e)
        {
            List<string> elementosOrdenados = sortedSet.ToList();
            elementosOrdenados.Reverse();

            for (int i = 0; i < elementosOrdenados.Count; i++)
            {
                DgvListado.Rows[i].Cells[2].Value = elementosOrdenados[i];
            }
        }
    }
}
