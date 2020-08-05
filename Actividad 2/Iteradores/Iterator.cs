namespace Actividad_2
{
    interface Iterator
    {
        void primero();
        void siguiente();
        bool fin();
        object posicionActual();
    }

    interface Iterable
    {
        Iterator crearIterador();
    }
}