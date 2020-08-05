using System;
using Actividad_1;
using Actividad_2;
using System.Collections.Generic;

namespace Actividad_3
{
    class Vendedor: Persona, IObservado
    {
        private double sueldoBasico;
        private double bonus;
        private List<IObservador> observadores;
        private double ultimaVenta;

        public Vendedor(string n, double d, double s): base(n,d)
        {
            this.nombre = n;
            this.dni = d;
            this.sueldoBasico = s;
            this.bonus = 1;
            this.ultimaVenta = 0;
            this.comparacion = new PorBonus(this);
            this.observadores = new List<IObservador>();
        }

        public void venta(double monto)
        {
            this.ultimaVenta = monto;
            notificar();
        }

        public void aumentaBonus()
        {
            bonus = bonus + bonus*0.1;
        }

        public double getBonus()
        {
            return this.bonus;
        }

        public override string ToString()
        {
            return this.nombre + " - " + this.bonus + " - " + this.ultimaVenta;
        }

        public void agregarObservador(IObservador observador)
        {
            this.observadores.Add(observador);
        }

        public void quitarObservador(IObservador observador)
        {
            this.observadores.Remove(observador);
        }

        public void notificar()
        {
            for(int i=0;i<observadores.Count;i++)
            {
                observadores[i].actualizar(this);
            }
        }

        public double getUltimaVenta()
        {
            return this.ultimaVenta;
        }
    }
}