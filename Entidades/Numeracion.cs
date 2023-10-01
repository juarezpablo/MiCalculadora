using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Numeracion
    {
        public enum Esistema { Decimal, Binario };
        private Esistema sistema;
        private double valorNumerico;
        
        
        public string Valor
            {
            get
                {
                    return this.sistema;
                 }
            
            }
        public Numeracion(Esistema sistema,double valorNum)
        {
            this.sistema=sistema;
            this.valorNumerico=valorNum;
        }



    }
}