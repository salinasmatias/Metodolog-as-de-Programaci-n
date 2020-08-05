using System;
using Actividad_1;
using Actividad_2;
using Actividad_3;

namespace Actividad_4
{
    interface IAlumno: Comparable
    {
        double getCalificacion();
        void setCalificacion(double valor);
        int responderPregunta(int pregunta);
        string mostrarCalificacion();
        string getNombre();
        double getDNI();
        double getLegajo();
        double getPromedio();
    }
}