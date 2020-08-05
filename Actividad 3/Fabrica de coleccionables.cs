using System;
using Actividad_1;
using Actividad_2;

namespace Actividad_3
{
    abstract class FabricaDeColeccionables
    {
        public const int PILA = 1;
        public const int COLA = 2;
        public const int CONJUNTO = 3;
        public const int DICCIONARIO = 4;

        public static Coleccionable crearColeccionable(int queColeccionable)
        {
            FabricaDeColeccionables fabrica = null;
            switch (queColeccionable)
            {
                case PILA:
                fabrica = new FabricaDePilas();
                break;

                case COLA:
                fabrica = new FabricaDeColas();
                break;

                case CONJUNTO:
                fabrica = new FabricaDeConjuntos();
                break;

                case DICCIONARIO:
                fabrica = new FabricaDeDiccionarios();
                break;

                default:
                Console.WriteLine("No es un tipo válido");
                break;
            }
            return fabrica.crearColeccionable();
            
        }
        public abstract Coleccionable crearColeccionable();
    }

    class FabricaDePilas:FabricaDeColeccionables
    {
        override public Coleccionable crearColeccionable()
        {
            return new Pila();
        }
    }

    class FabricaDeColas:FabricaDeColeccionables
    {
        override public Coleccionable crearColeccionable()
        {
            return new Cola();
        }
    }

    class FabricaDeConjuntos:FabricaDeColeccionables
    {
        override public Coleccionable crearColeccionable()
        {
            return new Conjunto();
        }
    }

    class FabricaDeDiccionarios:FabricaDeColeccionables
    {
        override public Coleccionable crearColeccionable()
        {
            return new Diccionario();
        }
    }

}