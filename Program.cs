﻿using System;
using Actividad_1;
using Actividad_2;
using Actividad_3;
using Actividad_4;
using Actividad_5;
using Actividad_6;
using MetodologíasDeProgramaciónI;
using ObtencionDeDatos;

namespace Actividad_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula aula = new Aula();
            OrdenInicio ordenInicio = new OrdenInicio(aula);
            OrdenAulaLlena ordenEnAulaLlena = new OrdenAulaLlena(aula);
            OrdenLlegaAlumno ordenLlegaAlumno = new OrdenLlegaAlumno(aula);
            Pila pila = new Pila();
            pila.setOrdenInicio(ordenInicio);
            pila.setOrdenEnAulaLlena(ordenEnAulaLlena);
            pila.setOrdenLlegaAlumno(ordenLlegaAlumno);
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

        public static ManejadorDeDatos crearCadenaDeResponsabilidades()
        {
            ManejadorDeDatos m = LectorDeDatos.getInstance(null);
            m = GeneradorDeDatosAleatorios.getInstance(m);
            m = new LectorDeArchivos(m);
            
            return m;
        }
        
        static IAlumno crearAlumnoDecorado(IAlumno parametro)
        {
            return parametro;
        }

        static IAlumno crearAlumnoDecoradoConLegajo(IAlumno parametro)
        {
            IAlumno alumno = crearAlumnoDecorado(parametro);
            return new DecoratorLegajo(alumno);
        }

        static IAlumno crearAlumnoDecoradoConLegajoYLetras(IAlumno parametro)
        {
            IAlumno alumno = crearAlumnoDecoradoConLegajo(parametro);
            return new DecoratorConLetras(alumno);
        }

        static IAlumno crearAlumnoDecoradoConLegajoLetrasYPromocion(IAlumno parametro)
        {
            IAlumno alumno = crearAlumnoDecoradoConLegajoYLetras(parametro);
            return new DecoratorPromocion(alumno);
        }

        static IAlumno crearAlumnoDecoradoConLegajoLetrasPromocionEIndice(IAlumno parametro)
        {
            IAlumno alumno = crearAlumnoDecoradoConLegajoLetrasYPromocion(parametro);
            return new DecoratorIndice(alumno);
        }

        public static IAlumno crearAlumnoDecoradoConLegajoLetrasPromocionIndiceYAsteriscos(IAlumno parametro)
        {
            IAlumno alumno = crearAlumnoDecoradoConLegajoLetrasPromocionEIndice(parametro);
            return new DecoratorConAsteriscos(alumno);
        }
        
        static void llenar(Coleccionable parametro, int opcion)
        {
            for(int i=0;i<20;i++)
            {
                parametro.agregar(Fabrica.crearAleatorio(opcion));
            }
        }

        static void informar (Coleccionable parametro, int opcion)
        {
            Console.WriteLine("Cantidad de elementos en el coleccionable: {0}", parametro.cuantos());
            Console.WriteLine("Elemento mínimo en el coleccionable: {0}", parametro.minimo());
            Console.WriteLine("Elemento máximo en el coleccionable: {0}{1}", parametro.maximo(), "\n");

            Comparable comparable = Fabrica.crearPorTeclado(opcion);
            if(parametro.contiene(comparable))
            {
                Console.WriteLine("\nEl elemento leido está en la colección.");
            }else
            {
                Console.WriteLine("\nEl elemento leido no está en la colección.");
            }
        }
        
        static void ImprimirElementos(Coleccionable coleccionable)
        {
            Iterator iterator = ((Iterable)coleccionable).crearIterador();
            for(int i=0; i< coleccionable.cuantos(); i++)
            {
                Console.WriteLine(((Comparable)iterator.posicionActual()).ToString()+"\n");
                iterator.siguiente();
            }
        }

        static void cambiarEstrategia(Coleccionable coleccionable, Comparable estrategia)
        {
            Iterator iterator = ((Iterable)coleccionable).crearIterador();
            for(int i=0; i< coleccionable.cuantos(); i++)
            {
                ((Alumno)iterator.posicionActual()).setComparacion(estrategia);
                iterator.siguiente();
            }
        }

        static void jornadaDeVentas(Coleccionable vendedores)
        {
            //GeneradorDeDatosAleatorios giveMeRandom = new GeneradorDeDatosAleatorios();
            ManejadorDeDatos manejador = crearCadenaDeResponsabilidades();
            Iterator iterator = ((Iterable)vendedores).crearIterador();
            int monto = 0;
            for (int i=0;i<20;i++)
            {
                monto = manejador.numeroAleatorio(7000);
                ((Vendedor)iterator.posicionActual()).venta(monto);
                //Console.WriteLine(((Vendedor)iterator.posicionActual()).getUltimaVenta());
                iterator.siguiente();
            }
        }

        static void hacerGerenteObservador(Pila pila, Gerente gerente)
        {
            foreach (Vendedor item in pila.getPila())
            {
                item.agregarObservador(gerente);
            }
        }
    }
}