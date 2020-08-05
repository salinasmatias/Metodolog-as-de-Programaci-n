using System;

namespace Actividad_3
{
    interface IObservador
    {
        void actualizar(IObservado observado);
    }

    interface IObservado
    {
        void agregarObservador(IObservador observador);
        void quitarObservador(IObservador observador);
        void notificar();
    }
}