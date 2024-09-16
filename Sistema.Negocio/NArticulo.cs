﻿using Sistema.Datos;
using Sistema.Entidades;
using System.Data;

namespace Sistema.Negocio
{
    public class NArticulo
    {
        public static DataTable Listar()
        {
            DArticulo Datos = new DArticulo();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Buscar(Valor);
        }
        public static DataTable BuscarVenta(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarVenta(Valor);
        }
        public static DataTable BuscarCodigo(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarCodigo(Valor);
        }
        public static DataTable BuscarCodigoVenta(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarCodigoVenta(Valor);
        }
        public static string Insertar(int IdCategoria, string Codigo, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)
        {
            DArticulo Datos = new DArticulo();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El articulo ya existe";
            }
            else
            {
                Articulo obj = new Articulo();
                obj.IdCategoria = IdCategoria;
                obj.Codigo = Codigo;
                obj.Nombre = Nombre;
                obj.PrecioVenta = PrecioVenta;
                obj.Stock = Stock;
                obj.Descripcion = Descripcion;
                obj.Imagen = Imagen;
                return Datos.Insertar(obj);
            }
        }
        public static string Actualizar(int Id, int IdCategoria, string Codigo, string NombreAnt, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)
        {
            DArticulo Datos = new DArticulo();
            Articulo obj = new Articulo();
            if (NombreAnt.Equals(Nombre))
            {
                obj.IdArticulo = Id;
                obj.IdCategoria = IdCategoria;
                obj.Codigo = Codigo;
                obj.Nombre = Nombre;
                obj.PrecioVenta = PrecioVenta;
                obj.Stock = Stock;
                obj.Descripcion = Descripcion;
                obj.Imagen = Imagen;
                return Datos.Actualizar(obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "El articulo ya existe";
                }
                else
                {
                    obj.IdArticulo = Id;
                    obj.IdCategoria = IdCategoria;
                    obj.Codigo = Codigo;
                    obj.Nombre = Nombre;
                    obj.PrecioVenta = PrecioVenta;
                    obj.Stock = Stock;
                    obj.Descripcion = Descripcion;
                    obj.Imagen = Imagen;
                    return Datos.Actualizar(obj);
                }
            }
        }
        public static string Eliminar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Eliminar(Id);
        }
        public static string Activar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Desactivar(Id);
        }
    }
}
