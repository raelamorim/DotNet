using System;

namespace TesteEnum.Exceptions
{
    internal class CodigoNaoDefinidoException : Exception
    {
        private string v;

        public CodigoNaoDefinidoException(string v)
        {
            this.v = v;
        }
    }
}