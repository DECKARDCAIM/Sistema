using System;
using System.Windows.Forms;

namespace Sistema.Presentacion.Reportes
{
    public partial class FrmReporteComprobanteVenta : Form
    {
        public FrmReporteComprobanteVenta()
        {
            InitializeComponent();
        }

        private void FrmReporteComprobanteVenta_Load(object sender, EventArgs e)
        {
            this.venta_comprobanteTableAdapter.Fill(this.dsSistema.venta_comprobante, Variables.IdVenta);
            this.reportViewer1.RefreshReport();
        }
    }
}
