using System.Collections.Generic;

namespace Actividad_1
{
    class ColeccionMultiple: Coleccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        //Es interesante como se utiliza los métodos de los atributos dentro del método a definir
        public int cuantos()
        {
            return this.pila.cuantos() + this.cola.cuantos();
        }

        public Comparable minimo()
        {
            Comparable minPila = this.pila.minimo();
            Comparable minCola = this.cola.minimo();
            if (minPila.sosMenor(minCola))
            {
                return minPila;
            }
            else
            {
                return minCola;
            }
        }

        public Comparable maximo()
        {
            Comparable maxPila = this.pila.maximo();
            Comparable maxCola = this.cola.maximo();
            if (maxPila.sosMayor(maxCola))
            {
                return maxPila;
            }
            else
            {
                return maxCola;
            }

        }

        public bool contiene(Comparable comparable)
        {
            bool tienepila = this.pila.contiene(comparable);
            bool tienecola = this.cola.contiene(comparable);
            if (tienepila || tienecola)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void agregar(Comparable comparable)
        {
            
        }

        public List<Comparable> getCola()
        {
            return this.cola.getCola();
        }

        public List<Comparable> getPila()
        {
            return this.pila.getPila();
        }

    }
}