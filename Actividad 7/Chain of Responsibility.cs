using System;
using Actividad_3;

namespace Actividad_7
{
    abstract class ManejadorDeDatos
    {
        private ManejadorDeDatos sucesor = null;

        public ManejadorDeDatos(ManejadorDeDatos parametro)
        {
            this.sucesor = parametro;
        }

        virtual public int numeroPorTeclado()
        {
            if(this.sucesor != null)
            {
                return this.sucesor.numeroPorTeclado();
            }
            return -1;
        }

        virtual public string stringPorTeclado()
        {
            if(this.sucesor != null)
            {
                return this.sucesor.stringPorTeclado();
            }
            return null;
        }

        virtual public int numeroAleatorio(int max)
        {
            if(this.sucesor != null)
            {
                return this.sucesor.numeroAleatorio(max);
            }
            return -1;
        }

        virtual public string stringAleatorio(int cant)
        {
            if(this.sucesor != null)
            {
                return this.sucesor.stringAleatorio(cant);
            }
            return null;
        }

        virtual public double numeroDesdeArchivo(double max)
        {
            if(this.sucesor != null)
            {
                return this.sucesor.numeroDesdeArchivo(max);
            }
            return -1;
        }

        virtual public string stringDesdeArchivo(int cant)
        {
            if(this.sucesor != null)
            {
                return this.sucesor.stringDesdeArchivo(cant);
            }
            return null;
        }
    }
}