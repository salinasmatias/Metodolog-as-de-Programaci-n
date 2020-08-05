/*Cambios realizados en Actividad 3: Se quitó la implementación previa de los métodos de
la interfaz comparable para implementarlos en el archivo Estrategias.cs en la carpeta
correspondiente a la actividad 2. Ahora, esta clase utiliza estos métodos mediante el uso
del patrón de diseño Strategy. Con esto, se quitó bastante código innecesario en la clase
Alumno (y en futuras clases que hereden de esta clase). De momento, se ha optado por dejar
los métodos de la interface Comparable como virtuales, permitiéndole a clases que hereden
de esta clase sobreescribirlos mediante override. Se ha modificado el constructor de esta clase
añadiendo a cada instancia una estrategia de comparación PorDNI por defecto. Esta puede ser
modificada mediante el uso del método setComparacion. */

using Actividad_2;
namespace Actividad_1
{
    public class Persona:Comparable
    {
        protected string nombre;
        protected double dni;
        protected Comparable comparacion;

        public Persona(string n, double d)
        {
            this.nombre = n;
            this.dni = d;
            this.comparacion = new PorDNI(this);
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getDNI()
        {
            return this.dni;
        }

        virtual public bool sosIgual(Comparable comparable)
        {
            return this.comparacion.sosIgual(comparable);
        }

        virtual public bool sosMenor(Comparable comparable)
        {
            return this.comparacion.sosMenor(comparable);
        }

        virtual public bool sosMayor(Comparable comparable)
        {
            return this.comparacion.sosMayor(comparable);
        }

        virtual public void setComparacion(Comparable comparacion)
        {
            this.comparacion = comparacion;
        }

        public override string ToString()
        {
            return this.nombre + " - " + this.dni;
        }

    }
}