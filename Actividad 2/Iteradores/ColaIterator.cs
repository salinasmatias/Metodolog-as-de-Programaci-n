using Actividad_1;

namespace Actividad_2
{
    class ColaIterator: Iterator
    {
        private int actual;
        private Cola cola = new Cola();

        public ColaIterator(Cola parametro)
        {
            this.cola = parametro;
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
            return actual >= cola.cuantos();
        }

        public object posicionActual()
        {
            return this.cola.getCola()[actual];
        }
    }
}