using Actividad_1;

namespace Actividad_2
{
    class PilaIterator: Iterator
    {
        private int actual;
        private Pila pila = new Pila();

        public PilaIterator(Pila parametro)
        {
            this.pila = parametro;
        }

        public void primero()
        {
            this.actual = 0;
        }

        public void siguiente()
        {
            this.actual++;
        }

        public bool fin()
        {
            return actual >= pila.cuantos();
        }

        public object posicionActual()
        {
            return this.pila.getPila()[actual];
        }
    }
}