using System.Collections.Generic;
using Actividad_1;
using Actividad_5;

namespace Actividad_2
{
    class Diccionario: Coleccionable, Iterable, Ordenable
    {
        private Conjunto conjunto;
        static Comparable clave = new Numero(0);
        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenEnAulaLlena;

        public Diccionario()
        {
            this.conjunto = new Conjunto();
        }

        public object valorDe(Comparable clave)
        {
            for(int i=0; i<this.conjunto.cuantos();i++)
            {
                if(this.conjunto.getConjunto()[i].sosIgual(clave))
                {
                    return ((ClaveValor)this.conjunto.getConjunto()[i]).getValor();
                }
            }

            return null;
        }

         public void Agregar(object valor, Comparable clave)
        {
            ClaveValor claveValor = new ClaveValor(valor, clave);
            foreach (Comparable a in conjunto.getConjunto())
            {
                if (((ClaveValor)a).sosIgual(claveValor))
                {
                    ((ClaveValor)a).setValor(valor);
                    break;
                }
            }            
            conjunto.agregar(claveValor);
        }

        public void agregar(Comparable comparable)
        {
            this.Agregar(comparable, clave = new Numero (((Numero)clave).getValor() + 1));
            if(this.cuantos()==1 & this.ordenInicio != null)
            {
                this.ordenInicio.ejecutar();
            }
            if(this.ordenLlegaAlumno != null)
            {
                this.ordenLlegaAlumno.ejecutar(comparable);
            } 
            if(this.cuantos()==40 & this.ordenEnAulaLlena != null)
            {
                this.ordenEnAulaLlena.ejecutar();
            }
        }

        public int cuantos()
        {
            return conjunto.cuantos();
        }

        public Comparable maximo()
        {
            return conjunto.maximo();
        }

        public Comparable minimo()
        {
            return conjunto.minimo();
        }

        public bool contiene(Comparable comparable)
        {
            return conjunto.pertenece(comparable);
        }

        public List<Comparable> getDiccionario()
        {
            return this.conjunto.getConjunto();
        }

        public Iterator crearIterador()
        {
            return new DiccionarioIterator(this);
        }

        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            this.ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }

        public void setOrdenEnAulaLlena(OrdenEnAula1 orden)
        {
            this.ordenEnAulaLlena = orden;
        }
    }
}