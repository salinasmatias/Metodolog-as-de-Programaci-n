namespace Actividad_1
{
    interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable valor);
        bool contiene (Comparable valor);

    }
}