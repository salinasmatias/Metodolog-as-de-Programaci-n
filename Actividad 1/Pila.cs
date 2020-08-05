using System.Collections.Generic;
using Actividad_2;
using Actividad_5;


namespace Actividad_1
{
    class Pila:Coleccionable, Iterable,Ordenable
    {
        private List<Comparable> pila;
        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenEnAulaLlena;

        public Pila()
        {
            this.pila = new List<Comparable>();
        }

        public int cuantos()
        {
            return this.pila.Count;
        }

        public Comparable minimo()
        {
            Comparable minimo = this.pila[0];
            for(int i=0;i<this.cuantos();i++)
            {
                if( this.pila[i].sosMenor(minimo))
                {
                    minimo = this.pila[i];
                }
            }
            return minimo;
        }

        public Comparable maximo()
        {
            Comparable maximo = this.pila[0];
            for(int i=0;i<this.cuantos();i++)
            {
                if( this.pila[i].sosMayor(maximo))
                {
                    maximo = this.pila[i];
                }
            }
            return maximo;
        }

        public void agregar(Comparable parametro)
        {
            this.pila.Add(parametro);
            if(this.cuantos()==1 & this.ordenInicio != null)
            {
                this.ordenInicio.ejecutar();
            }
            if(this.ordenLlegaAlumno != null)
            {
                this.ordenLlegaAlumno.ejecutar(parametro);
            }
            if(this.cuantos()==43 & this.ordenEnAulaLlena !=null)
            {
                this.ordenEnAulaLlena.ejecutar();
            }
        }

        public bool contiene(Comparable parametro)
        {
            foreach (Comparable a in pila)
            {
                if (a.sosIgual(parametro))
                {
                    return true;
                }
            }
            return false; 
        }

        public List<Comparable> getPila()
        {
            return this.pila;
        }

        public Iterator crearIterador()
        {
            return new PilaIterator(this);
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