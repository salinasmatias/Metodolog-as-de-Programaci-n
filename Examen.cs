using System;
using System.Collections.Generic;
using Actividad_1;
using Actividad_3;
using Actividad_4;
using Actividad_5;
using Actividad_6;

namespace Salinas
{

	public class Examen
	{
		public static void ejecutar()
		{
			Aula aula = new Aula();
            OrdenInicio ordenInicio = new OrdenInicio(aula);
            OrdenAulaLlena ordenEnAulaLlena = new OrdenAulaLlena(aula);
            OrdenLlegaAlumno ordenLlegaAlumno = new OrdenLlegaAlumno(aula);
            
            OrdenCompuesta ordenCompuesta = new OrdenCompuesta();
           // ordenCompuesta.agregarHijo(ordenInicio);
           // ordenCompuesta.agregarHijo(ordenEnAulaLlena);
            //ordenCompuesta.agregarHijo(ordenLlegaAlumno);
            
            Pila pila = new Pila();
            pila.setOrdenEnAulaLlena(ordenCompuesta);
            llenar(pila, 6);
            llenar(pila, 7);
            
            Comparable alumnoCompuesto = Fabrica.crearAleatorio(5);
            for(int i=0; i<5; i++)
            {
                Comparable alumno = Fabrica.crearPorArchivo(6);
                ((AlumnoCompuesto)alumnoCompuesto).agregarHijo((IAlumno)alumno);
            }
            pila.agregar(alumnoCompuesto);
            Comparable AlumnoEstudioso1 = Fabrica.crearPorTeclado(7);
            Comparable AlumnoEstudioso2 = Fabrica.crearPorTeclado(7);
            pila.agregar(AlumnoEstudioso1);
            pila.agregar(AlumnoEstudioso2);
		}

		private static void llenar(Coleccionable parametro, int opcion)
        {
            for(int i=0;i<20;i++)
            {
                parametro.agregar(Fabrica.crearAleatorio(opcion));
            }
        }

        class OrdenCompuesta:OrdenEnAula1
        {
            private List<OrdenEnAula1> ordenes = new List<OrdenEnAula1>();
            
            public void ejecutar()
            {
                foreach (OrdenEnAula1 orden in this.ordenes)
                {
                    orden.ejecutar();
                }
            }
        }

	}
}
