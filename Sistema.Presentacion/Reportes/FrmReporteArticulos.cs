using System;
using System.Windows.Forms;

namespace Sistema.Presentacion.Reportes
{
    public partial class FrmReporteArticulos : Form
    {
        public FrmReporteArticulos()
        {
            InitializeComponent();
        }

        private void FrmReporteArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.articulo_listar' Puede moverla o quitarla según sea necesario.
            this.articulo_listarTableAdapter.Fill(this.dsSistema.articulo_listar);
            this.reportViewer1.RefreshReport();
        }
    }
}
