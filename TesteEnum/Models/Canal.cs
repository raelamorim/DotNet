using System;
using static TesteEnum.Utils.EnumFlags;

namespace TesteEnum.Models
{
    public enum Canal
    {
        [Codigo("A1"), Descricao("Sistema utilizado pelo gerente da agência")]
        Agencia,

        [Codigo("A2"), Descricao("Caixa eletrônico")]
        Caixa_Eletronico,

        [Codigo("A3"), Descricao("Aplicativo para Celular")]
        Aplicativo_Celular,

        [Codigo("A4"), Descricao("Site da Internet")]
        Site_Internet
    }

}