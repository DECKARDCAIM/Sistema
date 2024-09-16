using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Data;

namespace Sistema.Negocio
{
    public class NVenta
    {
        public static DataTable Listar()
        {
            DVenta Datos = new DVenta();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DVenta Datos = new DVenta();
            return Datos.Buscar(Valor);
        }
        public static DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            DVenta Datos = new DVenta();
            return Datos.ConsultaFechas(FechaInicio, FechaFin);
        }
        public static DataTable ListarDetalle(int Id)
        {
            DVenta Datos = new DVenta();
            return Datos.ListarDetalle(Id);
        }
        public static string Insertar(int IdCliente, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            DVenta Datos = new DVenta();
            Venta obj = new Venta();
            obj.IdCliente = IdCliente;
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
            DVenta Datos = new DVenta();
            return Datos.Anular(Id);
        }
    }
}
