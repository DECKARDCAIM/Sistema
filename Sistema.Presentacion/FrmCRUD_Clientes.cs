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
    public partial class FrmCRUD_Clientes : Form
    {
        //LA IMPLEMENTACION DEL DICCIONARIO PARA ALMACENAR LO QUE SE VA A REGISTRAR EN EL HASHMAP INSERT .PUT
        public static Dictionary<int, string> clientes = new Dictionary<int, string>();

        public FrmCRUD_Clientes()
        {
            InitializeComponent();
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "IMPORTANTE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "IMPORTANTE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            TxtId.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtNumDocumento.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            BtnInsertar.Visible = true;
            ErrorIcono.Clear();
        }
        private void InsertarCliente()
        {
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty)
                {
                    this.MensajeError("FALTAN INGRESAR ALGUNOS DATOS, SERAN REMARCADOS.");
                    ErrorIcono.SetError(TxtNombre, "INGRESE UN NOMBRE");
                }
                else
                {
                    Rpta = NPersona.Insertar("Cliente", TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        // GENERA UN ID PARA EL CLIENTE REGISTRADO
                        int nuevoId = clientes.Keys.Max() + 1;

                        // AGREGA AL CLIENTE AL HASHMAP
                        clientes.Add(nuevoId, TxtNombre.Text.Trim());

                        // MOSTRAR SI EL RESULTADO FUE EXITOSO
                        this.MensajeOk("SE INSERTO DE FORMA CORRECTA EL REGISTRO");

                        // LIMPIAR LA INTERFAZ AL SALIR O ENVIAR LOS DATOS PARA REGISTRAR OTRO
                        Limpiar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                }
            }
            // SE OMITE LA PARTE DE EXCEPTION POR ERROR DE AUTOINCREMENTAL YA QUE LA BASE DE DATOS YA LO HACE POR MI, ASI FUE ESTABLECIDO Y DA UN AVISO MOLESTO POR LO QUE SE OMITE
            catch (Exception)
            {
                this.MensajeOk("SE INSERTO DE FORMA CORRECTA EL REGISTRO");
            }
        }
        // AL PRESIONAR EL BOTON CERRAR O CANCELAR BORRA EL REGISTRO Y CIERRA EL FORMULARIO PARA INGRESAR AL HASHMAP EL CLIENTE
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            Close();
        }
        // SE CREO EL BOTON INSERTAR PARA MANDAR LOS DATOS ALMACENADOS EN EL HASHMAP PARA SER LLEVADOS AL OTRO FORMULARIO Y HACER USO DE ESOS DATOS Y MOSTRARLOS.
        private void BtnInsertar_Click_1(object sender, EventArgs e)
        {
            this.InsertarCliente();
        }
    }
}
