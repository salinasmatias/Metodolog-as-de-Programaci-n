using System;
using Actividad_1;
using Actividad_4;
using Actividad_5;
using System.Collections.Generic;

namespace Actividad_6
{
    class AlumnoCompuesto:IAlumno
    {
        private List<IAlumno> hijos = new List<IAlumno>();

        public void agregarHijo(IAlumno alumno)
        {
            this.hijos.Add(alumno);
        }

        public string getNombre()
        {
            string nombresCompuestos = "";
            foreach (IAlumno hijo in this.hijos)
            {
                nombresCompuestos = nombresCompuestos + " " + hijo.getNombre();
            }

            return nombresCompuestos;
        }

        public int responderPregunta(int pregunta)
        {
            int uno = 0;
            int dos = 0;
            int tres = 0;
            int respuestaMasVotada=0;

            foreach (IAlumno hijo in this.hijos)
            {
                if(hijo.responderPregunta(pregunta)==1)
                {
                    uno++;
                }
                if(hijo.responderPregunta(pregunta)==2)
                {
                    dos++;
                }
                if(hijo.responderPregunta(pregunta)==3)
                {
                    tres++;
                }
            }
            
            if (uno>dos & uno > tres)
            {
                respuestaMasVotada = uno;
            }
            if (dos>uno & dos > tres)
            {
                respuestaMasVotada = dos;
            }
            if(tres>uno & tres > dos)
            {
                respuestaMasVotada = tres;
            }

            if (uno == dos & dos == tres)
            {
                Random random = new Random();
                respuestaMasVotada = random.Next(1,4);
            }
            
            return respuestaMasVotada;
        }

        public double getCalificacion()
        {
            foreach (IAlumno hijo in this.hijos)
            {
               return hijo.getCalificacion();
            }
            return 0;
        }

        public double getDNI()
        {
            foreach (IAlumno hijo in this.hijos)
            {
                return hijo.getDNI();
            }
            return 0;
        }

        public double getPromedio()
        {
            foreach (IAlumno hijo in this.hijos)
            {
                return hijo.getPromedio();
            }
            return 0;
        }

        public void setCalificacion(double valor)
        {
            foreach (IAlumno hijo in this.hijos)
            {
                hijo.setCalificacion(valor);
            }
        }

        public double getLegajo()
        {
            foreach (IAlumno hijo in this.hijos)
            {
                return hijo.getCalificacion();
            }
            return 0;
        }

        public string mostrarCalificacion()
        {
            string calificaciones = "";
            foreach (IAlumno hijo in this.hijos)
            {
                calificaciones = calificaciones + " " + hijo.mostrarCalificacion();
            }
            return calificaciones;
        }

        public bool sosIgual(Comparable comparable)
        {
            foreach (IAlumno hijo in this.hijos)
            {
                if(comparable.sosIgual(hijo))
                {
                    return true;
                }
            }
            return false;
        }

        public bool sosMayor(Comparable comparable)
        {
            foreach (IAlumno hijo in this.hijos)
            {
                if(hijo.sosMenor(comparable))
                {
                    return false;
                }
            }
            return true;
        }

        public bool sosMenor(Comparable comparable)
        {
            foreach (IAlumno hijo in this.hijos)
            {
                if(hijo.sosMayor(comparable))
                {
                    return false;
                }
            }
            return true;
        }
    }
}