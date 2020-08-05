using System;
using Actividad_1;

namespace Actividad_3
{
    interface FabricaDeComparables
    {
        Comparable crearAleatorio();
        Comparable crearPorTeclado();
        Comparable crearPorArchivo();
    }
}