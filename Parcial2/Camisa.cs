﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Camisa : Prenda
    {

        public override double CalcularPrecio()
        {

            if (Forma == 1)
            {
                Descuento = 0.1;
                PrecioFinal = PrecioBase - (PrecioBase * Descuento);
                PrecioBase = PrecioFinal;

                if (Calidad == 2)
                {
                    Descuento = 0.3;
                    PrecioFinal = PrecioBase + (PrecioBase * Descuento);
                }
            }
            else
            {
                if (Calidad == 2)
                {
                    Descuento = 0.3;
                    PrecioFinal = PrecioBase + (PrecioBase * Descuento);
                    PrecioBase = PrecioFinal;
                }
            }

            PrecioFinal = PrecioFinal * Cantidad;

            return PrecioFinal;
        }

    }
}
