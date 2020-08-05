using System;
using Actividad_1;
using System.Collections.Generic;
using Actividad_5;

namespace Actividad_2
{
    class Conjunto:Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> conjunto;
        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenEnAulaLlena;

        public Conjunto()
        {
            this.conjunto = new List<Comparable>();
        }

        public void agregar(Comparable comparable)
        {
            bool existeElemento = false;
            for(int i=0;i<this.conjunto.Count;i++)
            {
               if(this.conjunto[i].sosIgual(comparable))
                {
                    existeElemento= true;
                }
            }
            if(existeElemento==false)
            {
                this.conjunto.Add(comparable);
            }
            if(this.cuantos()==1 & this.ordenInicio != null)
            {
                this.ordenInicio.ejecutar();
            }
            if(this.ordenLlegaAlumno != null)
            {
                this.ordenLlegaAlumno.ejecutar(comparable);
            } 
            if(this.cuantos()==40 & this.ordenEnAulaLlena !=null)
            {
                this.ordenEnAulaLlena.ejecutar();
            }
        }

        public bool pertenece(Comparable comparable)
        {
            bool existeElemento = false;

            for(int i=0; i<this.conjunto.Count; i++)
            {
                if(this.conjunto[i].sosIgual(comparable))
                {
                    existeElemento = true;
                }
            }

            return existeElemento;
        }

        public int cuantos()
        {
            return this.conjunto.Count;
        }

        public Comparable maximo()
        {
            Comparable maximo = this.conjunto[0];
            for(int i=0;i<this.cuantos();i++)
            {
                if( this.conjunto[i].sosMayor(maximo))
                {
                    maximo = this.conjunto[i];
                }
            }
            return maximo;
        }

        public Comparable minimo()
        {
            Comparable minimo = this.conjunto[0];
            for(int i=0;i<this.cuantos();i++)
            {
                if( this.conjunto[i].sosMenor(minimo))
                {
                    minimo = this.conjunto[i];
                }
            }
            return minimo;
        }

        public List<Comparable> getConjunto()
        {
            return this.conjunto;
        }

        public bool contiene(Comparable comparable)
        {
            return this.pertenece(comparable);
        }

        public Iterator crearIterador()
        {
            return new ConjuntoIterator(this);
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