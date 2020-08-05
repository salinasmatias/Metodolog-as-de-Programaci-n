using Actividad_1;
namespace Actividad_2
{
    class ClaveValor: Comparable
    {
        private object valor;
        private Comparable clave;

        public ClaveValor(object v, Comparable c)
        {
            this.valor = v;
            this.clave = c;
        }

        public object getValor()
        {
            return this.valor;
        }

        public void setValor(object v)
        {
            this.valor = v;
        }

        public Comparable getClave()
        {
            return this.clave;
        }

        public bool sosIgual(Comparable comparable)
        {
            if (((ClaveValor)(comparable)).getClave() == this.clave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable comparable)
        {
            if (((ClaveValor)(comparable)).getClave().sosMenor(comparable))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable comparable)
        {
            if (((ClaveValor)(comparable)).getClave().sosMayor(comparable))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return valor + " - " + clave ;
        }

    }
}