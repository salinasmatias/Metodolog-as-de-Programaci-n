using System;
using Actividad_1;
using Actividad_2;
using System.Collections.Generic;

namespace Actividad_3
{
    class Gerente:IObservador
    {
        private List<Vendedor> mejores = new List<Vendedor>();

        public void cerrar()
        {
            foreach (Vendedor item in this.mejores)
            {
                //Console.WriteLine(mejores.Count);
                Console.WriteLine(item.ToString());
            }
        }

        public void venta(double monto, Vendedor vendedor)
        {
            if(monto > 5000)
            {
                if(!this.mejores.Contains(vendedor))
                {
                    this.mejores.Add(vendedor);
                    
                    //Console.WriteLine("Vendedor agregado a mejores");
                }
                vendedor.aumentaBonus();
            }
        }

        public void actualizar(IObservado observado)
        {
            venta(((Vendedor)observado).getUltimaVenta(), (Vendedor)observado);
        }
    }
}