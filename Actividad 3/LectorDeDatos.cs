using System;
using Actividad_7;
namespace Actividad_3
{
    class LectorDeDatos:ManejadorDeDatos
    {
        private static LectorDeDatos unicoLector = null;

        private LectorDeDatos(ManejadorDeDatos parametro):base(parametro)
        {

        }
        
        override public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            return numero;
        }

        override public string stringPorTeclado()
        {
            Console.WriteLine("Ingrese un texto aquí: ");
            string unStringCualquiera = Console.ReadLine();

            return unStringCualquiera;
        }

        public static LectorDeDatos getInstance(ManejadorDeDatos parametro)
        {
            if(unicoLector == null)
            {
                unicoLector = new LectorDeDatos(parametro);
            }
            return unicoLector;
        }
    }
}