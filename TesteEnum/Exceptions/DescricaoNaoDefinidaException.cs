using System;

namespace TesteEnum.Exceptions
{
    internal class DescricaoNaoDefinidaException : Exception
    {
        private string v;

        public DescricaoNaoDefinidaException(string v)
        {
            this.v = v;
        }
    }
}