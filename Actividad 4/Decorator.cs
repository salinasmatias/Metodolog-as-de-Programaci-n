using Actividad_1;
using Actividad_2;
using Actividad_3;
using System;
using MetodologíasDeProgramaciónI;

namespace Actividad_4
{
    abstract class AdicionalDecorator: IAlumno
    {
        protected IAlumno adicional;

        public AdicionalDecorator(IAlumno a)
        {
            this.adicional = a;
        }

        virtual public double getCalificacion()
        {
            return this.adicional.getCalificacion();
        }

        virtual public void setCalificacion(double valor)
        {
            if(adicional != null)
            {
                this.adicional.setCalificacion(valor);
            }
        }
        
        virtual public int responderPregunta(int pregunta)
        {
            return this.adicional.responderPregunta(pregunta);
        }

        virtual public string mostrarCalificacion()
        {
            return this.adicional.mostrarCalificacion();
        }

        virtual public string getNombre()
        {
            return this.adicional.getNombre();
        }

        virtual public double getDNI()
        {
            return this.adicional.getDNI();
        }

        virtual public double getLegajo()
        {
            return this.adicional.getLegajo();
        }

        virtual public double getPromedio()
        {
            return this.adicional.getPromedio();
        }

        virtual public bool sosIgual(Comparable comparable)
        {
            return this.adicional.sosIgual(comparable);
        }

        virtual public bool sosMenor(Comparable comparable)
        {
            return this.adicional.sosMenor(comparable);
        }

        virtual public bool sosMayor(Comparable comparable)
        {
            return this.adicional.sosMayor(comparable);
        }
    }

    class DecoratorLegajo: AdicionalDecorator
    {
        
        public DecoratorLegajo(IAlumno decorador):base(decorador)
        {

        }

        override public string mostrarCalificacion()
        {
            return base.getNombre() + " " + this.adicional.getLegajo() +" "+ base.getCalificacion();
        }
    }

    class DecoratorConLetras:AdicionalDecorator
    {
        public DecoratorConLetras(IAlumno decorador):base(decorador)
        {

        }

        static string ToLetras(double nota)
        {
            switch (nota)
            {
                case 0:
                return "(CERO)";

                case 1:
                return "(UNO)";

                case 2:
                return "(DOS)";

                case 3:
                return "(TRES)";

                case 4:
                return "(CUATRO)";

                case 5:
                return "(CINCO)";

                case 6:
                return "(SEIS)";

                case 7:
                return "(SIETE)";

                case 8:
                return "(OCHO)";

                case 9:
                return "(NUEVE)";

                case 10:
                return "(DIEZ)";

                default:
                return "NO";
            }
        }

        override public string mostrarCalificacion()
        {
            return base.mostrarCalificacion() + ToLetras(base.getCalificacion());
        }
    }

    class DecoratorPromocion:AdicionalDecorator
    {
        public DecoratorPromocion(IAlumno decorador):base(decorador)
        {

        }

        public static string descripcion(double calificacion)
        {
            if (calificacion < 4)
            {
                return "DESAPROBADO";
            }
            if (calificacion >= 4 && calificacion < 7)
            {
                return "APROBADO";
            }
            if (calificacion >= 7)
            {
                return "PROMOCIONADO";
            }
            return "NO";
        }

        override public string mostrarCalificacion()
        {
            return base.mostrarCalificacion() + " " + descripcion(base.getCalificacion());
        }
    }

    class DecoratorIndice:AdicionalDecorator
    {
        static int indice = 1;

        public DecoratorIndice(IAlumno decorador):base(decorador)
        {

        }

        override public string mostrarCalificacion()
        {
            return indice++ + ") " + base.mostrarCalificacion();
        }
    }

    class DecoratorConAsteriscos: AdicionalDecorator
    {
        public DecoratorConAsteriscos(IAlumno decorador):base(decorador)
        {

        }

        override public string mostrarCalificacion()
        {
            return "*******************************************\n" + "*  "+base.mostrarCalificacion()+ "   *\n" + "*******************************************\n";
        }
    }

}