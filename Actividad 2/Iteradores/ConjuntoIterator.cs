namespace Actividad_2
{
    class ConjuntoIterator: Iterator
    {
        private int actual;
        private Conjunto conjunto = new Conjunto();

        public ConjuntoIterator(Conjunto parametro)
        {
            this.conjunto = parametro;
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
            return actual >= conjunto.cuantos();
        }

        public object posicionActual()
        {
            return this.conjunto.getConjunto()[actual];
        }
    }
}