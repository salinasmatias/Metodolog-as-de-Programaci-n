using System.Collections.Generic;
using Actividad_2;
using Actividad_5;


namespace Actividad_1
{
    class Cola:Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> cola;
        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenEnAulaLlena;

        public Cola()
        {
            this.cola = new List<Comparable>();
        }

        public int cuantos()
        {
            return this.cola.Count;
        }

        public Comparable minimo()
        {
            Comparable minimo = this.cola[0];
            
            for(int i=0;i<this.cuantos();i++)
            {
                if( this.cola[i].sosMenor(minimo))
                {
                    minimo = this.cola[i];
                }
            }
            return minimo;
        }

        public Comparable maximo()
        {
            Comparable maximo = this.cola[0];
            {
                for(int i=0;i<this.cuantos();i++)
                {
                    if( this.cola[i].sosMayor(maximo))
                    {
                        maximo = this.cola[i];
                    }
                }
            }
            return maximo;
        }

        public void agregar(Comparable parametro)
        {
            this.cola.Add(parametro);
            if(this.cuantos()==1 & this.ordenInicio != null)
            {
                this.ordenInicio.ejecutar();
            }
            if(this.ordenLlegaAlumno != null)
            {
                this.ordenLlegaAlumno.ejecutar(parametro);
            } 
            if(this.cuantos()==40 & this.ordenEnAulaLlena !=null)
            {
                this.ordenEnAulaLlena.ejecutar();
            }
        }

        public bool contiene(Comparable parametro)
        {
            foreach (Comparable a in cola)
            {
                if (a.sosIgual(parametro))
                {
                    return true;
                }
            }
            return false; 
        }

        public List<Comparable> getCola()
        {
            return this.cola;
        }

        public Iterator crearIterador()
        {
            return new ColaIterator(this);
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