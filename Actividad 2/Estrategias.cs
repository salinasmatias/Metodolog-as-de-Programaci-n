using Actividad_1;
using Actividad_3;
using Actividad_4;

//Cambios en actividad 3: Se modificaron las strategy PorNombre y PorDNI Para que puedan
//Ser implementadas por Instancias de la clase Persona o clases que hereden de Persona.
//De esta forma, no debería modificarse la funcionalidad de estas strategy para Alumno
//Y permite que otras clases hereden de persona y puedan implementar estas Strategy.

//Cambios en Actividad 4: Se modificaron las strategy para que en líneas generales quedasen
//más consistentes con la implementación hecha en la strategy PorCalificacion.
//En esta versión, cada instancia de las strategy tiene un atributo de clase de tipo persona,
//alumno o vendedor, y para hacer la comparación, la strategy utiliza su comparable asociado
//y solicita mediante un método lo que se desea comparar.

/*Cambios en actividad 5: Strategy de comparación PorLegajo y PorPromedio ahora trabajan con
IAlumnos.*/

namespace Actividad_2
{
    class PorNombre:Comparable
    {
        private Persona persona;

        public PorNombre(Persona persona)
        {
            this.persona = persona;
        }
        
        public bool sosIgual(Comparable persona)
        {
            if( ((Persona)persona).getNombre() == this.persona.getNombre())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable persona)
        {
            if(string.Compare(this.persona.getNombre(), ((Persona)persona).getNombre())==1)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable persona)
        {
            if(string.Compare(this.persona.getNombre(), ((Persona)persona).getNombre())==-1)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
    
    class PorDNI:Comparable
    {
        private Persona persona;

        public PorDNI(Persona persona)
        {
            this.persona = persona;
        }

        public bool sosIgual(Comparable persona)
        {
            if( ((Persona)persona).getDNI() == this.persona.getDNI())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable persona)
        {
            if(this.persona.getDNI() < ((Persona)persona).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable persona)
        {
            if(this.persona.getDNI() > ((Persona)persona).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class PorPromedio: Comparable
    {
        private IAlumno alumno;

        public PorPromedio(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public bool sosIgual(Comparable alumno)
        {
            if(this.alumno.getPromedio() == ((IAlumno)alumno).getPromedio())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable alumno)
        {
            if(this.alumno.getPromedio() < ((IAlumno)alumno).getPromedio())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable alumno)
        {
            if(this.alumno.getPromedio() > ((IAlumno)alumno).getPromedio())
            {
                return true;
            }else
            {
                return false;
            }
        }
    }

    class PorLegajo:Comparable
    {
        private IAlumno alumno;

        public PorLegajo(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public bool sosIgual(Comparable alumno)
        {
            if(this.alumno.getLegajo() == ((IAlumno)alumno).getLegajo())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable alumno)
        {
            if(this.alumno.getLegajo() < ((IAlumno)alumno).getLegajo())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable alumno)
        {
            if(this.alumno.getLegajo() > ((IAlumno)alumno).getLegajo())
            {
                return true;
            }else
            {
                return false;
            }
        }
    }

    class PorBonus:Comparable
    {
        private Vendedor vendedor;
        
        public PorBonus(Vendedor vendedor)
        {
            this.vendedor = vendedor;
        }

        public bool sosIgual(Comparable vendedor)
        {
            if(this.vendedor.getBonus() == ((Vendedor)vendedor).getBonus())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable vendedor)
        {
            if(this.vendedor.getBonus() < ((Vendedor)vendedor).getBonus())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable vendedor)
        {
            if(this.vendedor.getBonus() > ((Vendedor)vendedor).getBonus())
            {
                return true;
            }else
            {
                return false;
            }
        }
    }

    class PorCalificacion:Comparable
    {
        private IAlumno alumno;
        
        public PorCalificacion(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public bool sosIgual(Comparable alumno)
        {
            if(this.alumno.getCalificacion() == ((IAlumno)alumno).getCalificacion())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable alumno)
        {
            if(this.alumno.getCalificacion() > ((IAlumno)alumno).getCalificacion())
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable alumno)
        {
            if(this.alumno.getCalificacion() < ((IAlumno)alumno).getCalificacion())
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}