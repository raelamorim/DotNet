using System;

namespace TesteEnum.Utils
{
    public class EnumFlags
    {
        public class DescricaoAttribute : Attribute
        {
            public string Valor { get; private set; }
            public DescricaoAttribute(string valor)
            {
                this.Valor = valor;
            }
        }

        public class CodigoAttribute : Attribute
        {
            public string Valor { get; private set; }
            public CodigoAttribute(string valor)
            {
                this.Valor = valor;
            }
        }
    }
}