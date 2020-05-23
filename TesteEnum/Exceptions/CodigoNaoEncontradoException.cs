using System;

namespace TesteEnum.Exceptions
{
    internal class CodigoNaoEncontradoException : Exception
    {
        private string v;

        public CodigoNaoEncontradoException(string v)
        {
            this.v = v;
        }
    }
}