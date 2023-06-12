﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Ferreteria.Models
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int IdUsuario { get; set; }
        public string TotalProducto { get; set; }
        public decimal Total { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string FechaTexto { get; set; }
        public List<Detalle_Compra> oDetalle_Compra { get; set; }
    }
}