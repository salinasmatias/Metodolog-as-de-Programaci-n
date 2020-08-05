using Actividad_1;
using MetodologíasDeProgramaciónI;

namespace Actividad_4
{
    class Adapter: Student
    {
        IAlumno alumno;

        public Adapter(IAlumno s)
        {
            this.alumno = s;
        }

        public bool equals(Student student)
        {
            return this.alumno.sosIgual(((Adapter)student).getAlumno());
        }

        public bool greaterThan(Student student)
        {
            return this.alumno.sosMayor(((Adapter)student).getAlumno());
        }

        public bool lessThan(Student student)
        {
            return this.alumno.sosMenor(((Adapter)student).getAlumno());
        }

        public string getName()
        {
            return this.alumno.getNombre();
        }

        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
            this.alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return this.alumno.mostrarCalificacion();
        }

        public IAlumno getAlumno()
        {
            return this.alumno;
        }
    }
}