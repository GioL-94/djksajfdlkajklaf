using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    abstract class Prenda
    {
        protected int Tipo;
        protected int Forma;
        protected int Calidad;
        protected double PrecioBase;
        protected double PrecioFinal;
        protected int Cantidad;
        public double Descuento;

        public Prenda()
        {
            Tipo = Tipo;
            Forma = Forma;
            Calidad = Calidad;
            PrecioBase = PrecioBase;
            PrecioFinal = PrecioFinal;
            Cantidad = Cantidad;
        }


        public int getTipo()
        {
            return Tipo;
        }

        public void setTipo(int Tipo)
        {
            this.Tipo = Tipo;
        }

        public int getForma()
        {
            return Forma;
        }

        public void setForma(int Forma)
        {
            this.Forma = Forma;
        }

        public int getCalidad()
        {
            return Calidad;
        }

        public void setCalidad(int Calidad)
        {
            this.Calidad = Calidad;
        }

        public double getPrecioBase()
        {
            return PrecioBase;
        }

        public void setPrecioBase(double PrecioBase)
        {
            this.PrecioBase = PrecioBase;
        }

        public double getPrecioFinal()
        {
            return PrecioFinal;
        }

        public void setPrecioFinal(double PrecioFinal)
        {
            this.PrecioFinal = PrecioFinal;
        }

        public int getCantidad()
        {
            return Cantidad;
        }

        public void setCantidad(int Cantidad)
        {
            this.Cantidad = Cantidad;
        }


        public virtual double CalcularPrecio()
        {
            return PrecioFinal;
        }


    }
}
