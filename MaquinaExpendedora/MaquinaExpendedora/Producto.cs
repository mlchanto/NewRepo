﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{

    public class Producto 
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public Producto(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
