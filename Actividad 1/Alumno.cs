using System;
using Actividad_2;
using Actividad_4;

namespace Actividad_1
{
    /*Cambios en actividad 3: Se quitó el atributo Comparable comparación, ya que ahora
    Lo hereda de la Clase persona.
    Se quitó un constructor innecesario.
    Se quitaron métodos de interface comparable, ya que ahora son implementados en el
    Archivo de Estrategias.cs y utilizados en la clase Persona y esta clase los hereda. 
    Por defecto, la estrategia de comparación de esta clase es PorLegajo.*/
    
    class Alumno: Persona, IAlumno
    {
        private double legajo;
        private double promedio;
        private double calificacion;
        
        public Alumno(string n, double d, double l, double p): base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            this.comparacion = new PorCalificacion(this);
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

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setDNI(double dni)
        {
            this.dni = dni;
        }

        public void setLegajo(double legajo)
        {
            this.legajo = legajo;
        }

        public void setPromedio(double promedio)
        {
            this.promedio = promedio;
        }

        virtual public int responderPregunta(int pregunta)
        {
            Random rnd = new Random();
            return rnd.Next(1,4);
        }

        public string mostrarCalificacion()
        {
            return new string(this.nombre + " - " + this.calificacion);
        }

        public override string ToString()
        {
            return this.nombre + " - " + this.dni + " - " + this.legajo + " - " + this.promedio;
        }

    }
}