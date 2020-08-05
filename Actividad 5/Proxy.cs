using System;
using Actividad_1;
using Actividad_4;
using Actividad_2;
using Actividad_3;

/*Cambio en actividad 6: Agregado método responder, el cual devuelve la respuesta del método
responderPregunta*/

namespace Actividad_5
{
    class AlumnoProxy:IAlumno
    {
        protected IAlumno alumnoReal = null;
        private string nombre;
        private double DNI;
        private double legajo;
        private double promedio;
        private double calificacion;
        private int identidad;
        

        public AlumnoProxy(string n, double d, double l, double p)
        {
            this.nombre = n;
            this.DNI = d;
            this.legajo = l;
            this.promedio = p;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getDNI()
        {
            return this.DNI;
        }

        public double getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }
        
        public double getCalificacion()
        {
            return this.calificacion;
        }

        public void setCalificacion(double valor)
        {
            this.calificacion = valor;
        }

        public string mostrarCalificacion()
        {
            return new string(this.nombre + " - " + this.calificacion);
        }

        public bool sosIgual(Comparable comparable)
        {
            alumnoReal.setCalificacion(this.getCalificacion());
            return this.alumnoReal.sosIgual(comparable);
        }

        public bool sosMayor(Comparable comparable)
        {
            alumnoReal.setCalificacion(this.getCalificacion());
            return this.alumnoReal.sosMayor(comparable);
        }

        public bool sosMenor(Comparable comparable)
        {
            alumnoReal.setCalificacion(this.getCalificacion());
            return this.alumnoReal.sosMenor(comparable);
        }

        virtual public int responderPregunta(int pregunta)
        {
            int respuesta = 0;
            if(alumnoReal == null)
            {
                alumnoReal = (IAlumno)Fabrica.crearAleatorio(identidad);
                ((Alumno)alumnoReal).setNombre(this.nombre);
                ((Alumno)alumnoReal).setDNI(this.DNI);
                ((Alumno)alumnoReal).setLegajo(this.legajo);
                ((Alumno)alumnoReal).setPromedio(this.promedio);
                Console.WriteLine("Alumno Proxy creado");
            }
            respuesta = alumnoReal.responderPregunta(pregunta);

            return respuesta;
        }

        public void setIdentidad(int opcionFactory)
        {
            this.identidad = opcionFactory;
        }
    }
}