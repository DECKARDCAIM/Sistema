namespace Sistema.Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRTICULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuIngresos = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAccesos = new System.Windows.Forms.ToolStripMenuItem();
            this.rOLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAVENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTACOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAlmacen,
            this.MnuIngresos,
            this.MnuVentas,
            this.MnuAccesos,
            this.MnuConsultas});
            this.menuStrip.Location = new System.Drawing.Point(250, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip.Size = new System.Drawing.Size(848, 80);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuAlmacen
            // 
            this.MnuAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cATEGORIASToolStripMenuItem,
            this.aRTICULOSToolStripMenuItem});
            this.MnuAlmacen.Image = global::Sistema.Presentacion.Properties.Resources.Box;
            this.MnuAlmacen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuAlmacen.Name = "MnuAlmacen";
            this.MnuAlmacen.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.MnuAlmacen.Size = new System.Drawing.Size(140, 60);
            this.MnuAlmacen.Text = "ALMACEN";
            this.MnuAlmacen.Click += new System.EventHandler(this.aLMACENToolStripMenuItem_Click);
            // 
            // cATEGORIASToolStripMenuItem
            // 
            this.cATEGORIASToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_file_folder_64;
            this.cATEGORIASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cATEGORIASToolStripMenuItem.Name = "cATEGORIASToolStripMenuItem";
            this.cATEGORIASToolStripMenuItem.Size = new System.Drawing.Size(213, 70);
            this.cATEGORIASToolStripMenuItem.Text = "CATE&GORIAS";
            this.cATEGORIASToolStripMenuItem.Click += new System.EventHandler(this.cATEGORIASToolStripMenuItem_Click);
            // 
            // aRTICULOSToolStripMenuItem
            // 
            this.aRTICULOSToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_article_64__1_;
            this.aRTICULOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aRTICULOSToolStripMenuItem.Name = "aRTICULOSToolStripMenuItem";
            this.aRTICULOSToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.aRTICULOSToolStripMenuItem.Size = new System.Drawing.Size(213, 68);
            this.aRTICULOSToolStripMenuItem.Text = "&ARTICULOS";
            this.aRTICULOSToolStripMenuItem.Click += new System.EventHandler(this.aRTICULOSToolStripMenuItem_Click);
            // 
            // MnuIngresos
            // 
            this.MnuIngresos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROVEEDORESToolStripMenuItem,
            this.cOMPRASToolStripMenuItem});
            this.MnuIngresos.Image = global::Sistema.Presentacion.Properties.Resources.door_in;
            this.MnuIngresos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuIngresos.Name = "MnuIngresos";
            this.MnuIngresos.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.MnuIngresos.Size = new System.Drawing.Size(142, 60);
            this.MnuIngresos.Text = "INGRESOS";
            this.MnuIngresos.Click += new System.EventHandler(this.iNGRESOSToolStripMenuItem_Click);
            // 
            // pROVEEDORESToolStripMenuItem
            // 
            this.pROVEEDORESToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_supplier_64;
            this.pROVEEDORESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pROVEEDORESToolStripMenuItem.Name = "pROVEEDORESToolStripMenuItem";
            this.pROVEEDORESToolStripMenuItem.Size = new System.Drawing.Size(229, 70);
            this.pROVEEDORESToolStripMenuItem.Text = "&PROVEEDORES";
            this.pROVEEDORESToolStripMenuItem.Click += new System.EventHandler(this.pROVEEDORESToolStripMenuItem_Click);
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_wallet_64;
            this.cOMPRASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(229, 70);
            this.cOMPRASToolStripMenuItem.Text = "&COMPRAS";
            this.cOMPRASToolStripMenuItem.Click += new System.EventHandler(this.cOMPRASToolStripMenuItem_Click);
            // 
            // MnuVentas
            // 
            this.MnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.vENTASToolStripMenuItem1});
            this.MnuVentas.Image = global::Sistema.Presentacion.Properties.Resources.ventas_b;
            this.MnuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuVentas.Name = "MnuVentas";
            this.MnuVentas.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.MnuVentas.Size = new System.Drawing.Size(136, 60);
            this.MnuVentas.Text = "VENTAS";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_budget_64;
            this.cLIENTESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(194, 70);
            this.cLIENTESToolStripMenuItem.Text = "CLIEN&TES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // vENTASToolStripMenuItem1
            // 
            this.vENTASToolStripMenuItem1.Image = global::Sistema.Presentacion.Properties.Resources.icons8_banknotes_64;
            this.vENTASToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vENTASToolStripMenuItem1.Name = "vENTASToolStripMenuItem1";
            this.vENTASToolStripMenuItem1.Size = new System.Drawing.Size(194, 70);
            this.vENTASToolStripMenuItem1.Text = "&VENTAS";
            this.vENTASToolStripMenuItem1.Click += new System.EventHandler(this.vENTASToolStripMenuItem1_Click);
            // 
            // MnuAccesos
            // 
            this.MnuAccesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rOLESToolStripMenuItem,
            this.uSUARIOSToolStripMenuItem});
            this.MnuAccesos.Image = global::Sistema.Presentacion.Properties.Resources.group_key;
            this.MnuAccesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuAccesos.Name = "MnuAccesos";
            this.MnuAccesos.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.MnuAccesos.Size = new System.Drawing.Size(135, 60);
            this.MnuAccesos.Text = "ACCESOS";
            // 
            // rOLESToolStripMenuItem
            // 
            this.rOLESToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_permanent_job_64;
            this.rOLESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rOLESToolStripMenuItem.Name = "rOLESToolStripMenuItem";
            this.rOLESToolStripMenuItem.Size = new System.Drawing.Size(199, 70);
            this.rOLESToolStripMenuItem.Text = "&ROLES";
            this.rOLESToolStripMenuItem.Click += new System.EventHandler(this.rOLESToolStripMenuItem_Click);
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_badge_64;
            this.uSUARIOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(199, 70);
            this.uSUARIOSToolStripMenuItem.Text = "&USUARIOS";
            this.uSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click);
            // 
            // MnuConsultas
            // 
            this.MnuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONSULTAVENTASToolStripMenuItem,
            this.cONSULTACOMPRASToolStripMenuItem});
            this.MnuConsultas.Image = global::Sistema.Presentacion.Properties.Resources.consultas;
            this.MnuConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuConsultas.Name = "MnuConsultas";
            this.MnuConsultas.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.MnuConsultas.Size = new System.Drawing.Size(153, 60);
            this.MnuConsultas.Text = "CONSULTAS";
            // 
            // cONSULTAVENTASToolStripMenuItem
            // 
            this.cONSULTAVENTASToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_total_sales_64;
            this.cONSULTAVENTASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cONSULTAVENTASToolStripMenuItem.Name = "cONSULTAVENTASToolStripMenuItem";
            this.cONSULTAVENTASToolStripMenuItem.Size = new System.Drawing.Size(268, 70);
            this.cONSULTAVENTASToolStripMenuItem.Text = "CONSULTA VENTAS";
            this.cONSULTAVENTASToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAVENTASToolStripMenuItem_Click);
            // 
            // cONSULTACOMPRASToolStripMenuItem
            // 
            this.cONSULTACOMPRASToolStripMenuItem.Image = global::Sistema.Presentacion.Properties.Resources.icons8_analytics_64;
            this.cONSULTACOMPRASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cONSULTACOMPRASToolStripMenuItem.Name = "cONSULTACOMPRASToolStripMenuItem";
            this.cONSULTACOMPRASToolStripMenuItem.Size = new System.Drawing.Size(268, 70);
            this.cONSULTACOMPRASToolStripMenuItem.Text = "CONSULTA COMPRAS";
            this.cONSULTACOMPRASToolStripMenuItem.Click += new System.EventHandler(this.cONSULTACOMPRASToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema.Presentacion.Properties.Resources.ws_Black_and_White_Abstract_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "SISTEMA ADMINISTRATIVO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MnuAlmacen;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuIngresos;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuVentas;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuAccesos;
        private System.Windows.Forms.ToolStripMenuItem rOLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuConsultas;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAVENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTACOMPRASToolStripMenuItem;
    }
}



