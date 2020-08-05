namespace Actividad_2
{
    class DiccionarioIterator: Iterator
    {
        private int actual;
        private Diccionario diccionario = new Diccionario();

        public DiccionarioIterator(Diccionario parametro)
        {
            this.diccionario = parametro;
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
            return actual >= diccionario.cuantos();
        }

        public object posicionActual()
        {
            return this.diccionario.getDiccionario()[actual];
        }
    }
}