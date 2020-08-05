using System;
using Actividad_1;
using Actividad_2;
using Actividad_4;
using Actividad_5;
using Actividad_6;
using Actividad_7;

/*Cambios en actividad 4:

Se agregó una fábrica concreta: FabricaDeAlumnosMuyEstudiosos*/
/*Cambios actividad 5: Las fábricas concretas FabricaDeAlumnos y FabricaDeAlumnosMuyEstudiosos
ahora fabrican proxys de Alumnos y Alumnos muy estudiosos*/

namespace Actividad_3
{
    abstract class Fabrica:FabricaDeComparables
    {
        //atributos
        public const int NUMERO = 1;
        public const int ALUMNO = 2;
        public const int VENDEDOR = 3;
        public const int ALUMNO_MUY_ESTUDIOSO = 4;
        public const int ALUMNO_COMPUESTO = 5;
        public const int ALUMNO_PROXY = 6;
        public const int ALUMNO_MUY_ESTUDIOSO_PROXY =7;
        //métodos mágicos estático aquí
        public static Comparable crearAleatorio(int queComparable)
        {
            Fabrica fabrica = null;
            switch(queComparable)
            {
                case NUMERO:
                fabrica = new FabricaDeNumeros();
                break;
                
                case ALUMNO:
                fabrica = new FabricaDeAlumnos();
                break;

                case VENDEDOR:
                fabrica = new FabricaDeVendedores();
                break;

                case ALUMNO_MUY_ESTUDIOSO:
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
                break;

                case ALUMNO_COMPUESTO:
                fabrica = new FabricadeAlumnosCompuestos();
                break;

                case ALUMNO_PROXY:
                fabrica = new FabricaDeAlumnosProxy();
                break;

                case ALUMNO_MUY_ESTUDIOSO_PROXY:
                fabrica = new FabricaDeAlumnosProxyMuyEstudiosos();
                break;

                default:
                Console.WriteLine("No es un tipo válido");
                break;
            }
            return fabrica.crearAleatorio();
        }

        public static Comparable crearPorTeclado(int queComparable)
        {
            Fabrica fabrica = null;
            switch(queComparable)
            {
                case NUMERO:
                fabrica = new FabricaDeNumeros();
                break;
                
                case ALUMNO:
                fabrica = new FabricaDeAlumnos();
                break;

                case VENDEDOR:
                fabrica = new FabricaDeVendedores();
                break;

                case ALUMNO_MUY_ESTUDIOSO:
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
                break;

                case ALUMNO_COMPUESTO:
                fabrica = new FabricadeAlumnosCompuestos();
                break;

                case ALUMNO_PROXY:
                fabrica = new FabricaDeAlumnosProxy();
                break;

                case ALUMNO_MUY_ESTUDIOSO_PROXY:
                fabrica = new FabricaDeAlumnosProxyMuyEstudiosos();
                break;

                default:
                Console.WriteLine("No es un tipo válido");
                break;
            }
            return fabrica.crearPorTeclado();
        }

        public static Comparable crearPorArchivo(int queComparable)
        {
            Fabrica fabrica = null;
            switch(queComparable)
            {
                case NUMERO:
                fabrica = new FabricaDeNumeros();
                break;
                
                case ALUMNO:
                fabrica = new FabricaDeAlumnos();
                break;

                case VENDEDOR:
                fabrica = new FabricaDeVendedores();
                break;

                case ALUMNO_MUY_ESTUDIOSO:
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
                break;

                case ALUMNO_COMPUESTO:
                fabrica = new FabricadeAlumnosCompuestos();
                break;

                case ALUMNO_PROXY:
                fabrica = new FabricaDeAlumnosProxy();
                break;

                case ALUMNO_MUY_ESTUDIOSO_PROXY:
                fabrica = new FabricaDeAlumnosProxyMuyEstudiosos();
                break;

                default:
                Console.WriteLine("No es un tipo válido");
                break;
            }
            return fabrica.crearPorArchivo();
        }

        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
        public abstract Comparable crearPorArchivo();
    }

    class FabricaDeNumeros: Fabrica
    {
        //private GeneradorDeDatosAleatorios giveMerandom = new GeneradorDeDatosAleatorios();
        //private LectorDeDatos givemeData = new LectorDeDatos();
        private ManejadorDeDatos manejador = Program.crearCadenaDeResponsabilidades();
        override public Comparable crearAleatorio()
        {
            return new Numero(this.manejador.numeroAleatorio(11));
        }

        override public Comparable crearPorTeclado()
        {
            return new Numero(this.manejador.numeroPorTeclado());
        }

        override public Comparable crearPorArchivo()
        {
            return new Numero(this.manejador.numeroDesdeArchivo(100));
        }
    }

    class FabricaDeAlumnos: Fabrica
    {
        //private GeneradorDeDatosAleatorios giveMerandom = new GeneradorDeDatosAleatorios();
        //private LectorDeDatos givemeData = new LectorDeDatos();
         private ManejadorDeDatos manejador = Program.crearCadenaDeResponsabilidades();
        
        override public Comparable crearAleatorio()
        {
            return new Alumno(this.manejador.stringAleatorio(8),this.manejador.numeroAleatorio(600), this.manejador.numeroAleatorio(60000), this.manejador.numeroAleatorio(11));
        }

        override public Comparable crearPorTeclado()
        {
            return new Alumno(this.manejador.stringPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado());
        }

        override public Comparable crearPorArchivo()
        {
            return new Alumno(this.manejador.stringDesdeArchivo(10),this.manejador.numeroDesdeArchivo(500000), this.manejador.numeroDesdeArchivo(50000), this.manejador.numeroDesdeArchivo(11));
        }
    }

    class FabricaDeVendedores: Fabrica
    {
        //private GeneradorDeDatosAleatorios giveMerandom = new GeneradorDeDatosAleatorios();
        //private LectorDeDatos givemeData = new LectorDeDatos();
        private ManejadorDeDatos manejador = Program.crearCadenaDeResponsabilidades();

        override public Comparable crearAleatorio()
        {
            return new Vendedor(this.manejador.stringAleatorio(10), this.manejador.numeroAleatorio(600), this.manejador.numeroAleatorio(50000));
        }

        override public Comparable crearPorTeclado()
        {
            return new Vendedor(this.manejador.stringPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado());
        }

        override public Comparable crearPorArchivo()
        {
            return new Vendedor(this.manejador.stringDesdeArchivo(10), this.manejador.numeroDesdeArchivo(600), this.manejador.numeroDesdeArchivo(50000));
        }
    }

    class FabricaDeAlumnosMuyEstudiosos: Fabrica
    {
        //private GeneradorDeDatosAleatorios giveMerandom = new GeneradorDeDatosAleatorios();
        //private LectorDeDatos givemeData = new LectorDeDatos();
        private ManejadorDeDatos manejador = Program.crearCadenaDeResponsabilidades();
        
        override public Comparable crearAleatorio()
        {
            return new AlumnoMuyEstudioso(this.manejador.stringAleatorio(8),this.manejador.numeroAleatorio(600), this.manejador.numeroAleatorio(60000), this.manejador.numeroAleatorio(11));
        }

        override public Comparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(this.manejador.stringPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado());
        }

        override public Comparable crearPorArchivo()
        {
            return new AlumnoMuyEstudioso(this.manejador.stringDesdeArchivo(10),this.manejador.numeroDesdeArchivo(500000), this.manejador.numeroDesdeArchivo(50000), this.manejador.numeroDesdeArchivo(11));
        }
    }

    class FabricadeAlumnosCompuestos:Fabrica
    {
        override public Comparable crearAleatorio()
        {
            return new AlumnoCompuesto();
        }

        override public Comparable crearPorTeclado()
        {
            return new AlumnoCompuesto();
        }

        override public Comparable crearPorArchivo()
        {
            return new AlumnoCompuesto();
        }
    }

    class FabricaDeAlumnosProxy: Fabrica
    {
        //private GeneradorDeDatosAleatorios giveMerandom = new GeneradorDeDatosAleatorios();
        //private LectorDeDatos givemeData = new LectorDeDatos();
         private ManejadorDeDatos manejador = Program.crearCadenaDeResponsabilidades();
        
        override public Comparable crearAleatorio()
        {
            AlumnoProxy nuevoAlumno = new AlumnoProxy(this.manejador.stringAleatorio(8),this.manejador.numeroAleatorio(600), this.manejador.numeroAleatorio(60000), this.manejador.numeroAleatorio(11));
            nuevoAlumno.setIdentidad(2);
            return nuevoAlumno;
        }

        override public Comparable crearPorTeclado()
        {
            AlumnoProxy nuevoAlumno = new AlumnoProxy(this.manejador.stringPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado());
            nuevoAlumno.setIdentidad(2);
            return nuevoAlumno;
        }

        override public Comparable crearPorArchivo()
        {
            AlumnoProxy nuevoAlumno = new AlumnoProxy(this.manejador.stringDesdeArchivo(10),this.manejador.numeroDesdeArchivo(500000), this.manejador.numeroDesdeArchivo(50000), this.manejador.numeroDesdeArchivo(11));
            nuevoAlumno.setIdentidad(2);
            return nuevoAlumno;
        }
    }

    class FabricaDeAlumnosProxyMuyEstudiosos: Fabrica
    {
        //private GeneradorDeDatosAleatorios giveMerandom = new GeneradorDeDatosAleatorios();
        //private LectorDeDatos givemeData = new LectorDeDatos();
         private ManejadorDeDatos manejador = Program.crearCadenaDeResponsabilidades();
        
        override public Comparable crearAleatorio()
        {
            AlumnoProxy nuevoAlumno = new AlumnoProxy(this.manejador.stringAleatorio(8),this.manejador.numeroAleatorio(600), this.manejador.numeroAleatorio(60000), this.manejador.numeroAleatorio(11));
            nuevoAlumno.setIdentidad(4);
            return nuevoAlumno;
        }

        override public Comparable crearPorTeclado()
        {
            AlumnoProxy nuevoAlumno = new AlumnoProxy(this.manejador.stringPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado(), this.manejador.numeroPorTeclado());
            nuevoAlumno.setIdentidad(4);
            return nuevoAlumno;
        }

        override public Comparable crearPorArchivo()
        {
            AlumnoProxy nuevoAlumno = new AlumnoProxy(this.manejador.stringDesdeArchivo(10),this.manejador.numeroDesdeArchivo(500000), this.manejador.numeroDesdeArchivo(50000), this.manejador.numeroDesdeArchivo(11));
            nuevoAlumno.setIdentidad(4);
            return nuevoAlumno;
        }
    }
}