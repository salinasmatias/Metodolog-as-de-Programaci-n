using System;
using Actividad_7;
namespace Actividad_3
{
    class GeneradorDeDatosAleatorios:ManejadorDeDatos
    {
        private static GeneradorDeDatosAleatorios unicoGenerador;

        private GeneradorDeDatosAleatorios(ManejadorDeDatos parametro):base(parametro)
        {
            
        }
        
        override public int numeroAleatorio(int max)
        {
            Random rnd = new Random();

            return rnd.Next(0, max);
        }

        override public string stringAleatorio(int cant)
        {
            Random rnd = new Random();
            const string alfabeto = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] caracteres = new char[cant];

            for(int i=0;i<cant;i++)
            {
                caracteres[i] = alfabeto[rnd.Next(alfabeto.Length)];
            }

            return new string(caracteres);
        }

        public static GeneradorDeDatosAleatorios getInstance(ManejadorDeDatos parametro)
        {
            if(unicoGenerador == null)
            {
                unicoGenerador = new GeneradorDeDatosAleatorios(parametro);
            }
            return unicoGenerador;
        }
    }
}