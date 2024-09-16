using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Data;

namespace Sistema.Negocio
{
    public class NIngreso
    {
        public static DataTable Listar()
        {
            DIngreso Datos = new DIngreso();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DIngreso Datos = new DIngreso();
            return Datos.Buscar(Valor);
        }
        public static DataTable ListarDetalle(int Id)
        {
            DIngreso Datos = new DIngreso();
            return Datos.ListarDetalle(Id);
        }
        public static string Insertar(int IdProveedor, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            DIngreso Datos = new DIngreso();
            Ingreso obj = new Ingreso();
            obj.IdProveedor = IdProveedor;
            obj.IdUsuario = IdUsuario;
            obj.TipoComprobante = TipoComprobante;
            obj.SerieComprobante = SerieComprobante;
            obj.NumComprobante = NumComprobante;
            obj.Impuesto = Impuesto;
            obj.Total = Total;
            obj.Detalles = Detalles;
            return Datos.Insertar(obj);
        }
        public static String Anular(int Id)
        {
            DIngreso Datos = new DIngreso();
            return Datos.Anular(Id);
        }
    }
}
