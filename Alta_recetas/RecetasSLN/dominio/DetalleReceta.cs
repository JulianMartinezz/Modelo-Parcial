﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class DetalleReceta
    {
        public Ingrediente ingrediente { get; set; }
        public double cantidad  { get; set; }

        public DetalleReceta(Ingrediente I, int cant)
        {
            ingrediente = I;
            cantidad = cant;
        }
        
    }
}
