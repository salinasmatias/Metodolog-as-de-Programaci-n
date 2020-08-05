using MetodologíasDeProgramaciónI;
using Actividad_4;
using Actividad_6;
using Actividad_7;
using System;

namespace Actividad_5
{
    class Aula
    {
        Teacher teacher;

        public void comenzar()
        {
            Console.WriteLine("Class is now in session!");
            teacher = new Teacher();
        }

        public void nuevoAlumno(IAlumno alumno)
        {
            IAlumno alumnoDecorado = Program.crearAlumnoDecoradoConLegajoLetrasPromocionIndiceYAsteriscos(alumno);
            teacher.goToClass(new Adapter(alumnoDecorado));
        }

        public void claseLista()
        {
            teacher.teachingAClass();
        }
    }
}