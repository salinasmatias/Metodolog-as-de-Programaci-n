namespace Actividad_1
{
    class Numero:Comparable
    {
        private double valor;

        public Numero (double valor)
        {
            this.valor = valor;
        }

        public double getValor()
        {
            return this.valor;
        }

        public bool sosIgual(Comparable valor)
        {
            
            if(this.getValor() == ((Numero)(valor)).getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable valor)
        {
            if(this.getValor() > ((Numero)(valor)).getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable valor)
        {
            if(this.getValor() < ((Numero)(valor)).getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.valor.ToString();
        }

    }
}