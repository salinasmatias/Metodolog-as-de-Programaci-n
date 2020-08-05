using System;
using Actividad_1;
using Actividad_2;
using Actividad_4;

namespace Actividad_5
{
    interface OrdenEnAula1
    {
        void ejecutar();
    }

    interface OrdenEnAula2
    {
        void ejecutar(Comparable comparable);
    }

    interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 orden);
        void setOrdenLlegaAlumno(OrdenEnAula2 orden);
        void setOrdenEnAulaLlena(OrdenEnAula1 orden);
    }

    class OrdenInicio:OrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar()
        {
            this.aula.comenzar();
        }
    }

    class OrdenAulaLlena:OrdenEnAula1
    {
        Aula aula;

        public OrdenAulaLlena(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar()
        {
            this.aula.claseLista();
        }
    }

    class OrdenLlegaAlumno:OrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar(Comparable comparable)
        {
            this.aula.nuevoAlumno((IAlumno)comparable);
        }
    }
}