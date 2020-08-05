using System;
using Actividad_1;
using Actividad_2;
using Actividad_3;
using MetodologíasDeProgramaciónI;

namespace Actividad_4
{
    class AlumnoMuyEstudioso:Alumno
    {
        public AlumnoMuyEstudioso(string n, double d, double l, double p):base(n, d, l, p)
        {

        }

        override public int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}