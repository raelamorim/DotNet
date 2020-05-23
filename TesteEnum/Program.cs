using System;
using System.Collections.Generic;
using TesteEnum.Models;
using TesteEnum.Utils;

namespace TesteEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            var canais = new List<Canal>() 
            {
                EnumExtensions.FromCodigo<Canal>("A1"),
                Canal.Site_Internet,
                EnumExtensions.FromCodigo<Canal>("A3"),
                Canal.Caixa_Eletronico
            };

            foreach(Canal canal in canais) 
            {
                Console.Write ("Enum: " + canal.ToString() + ", código: " 
                    + canal.GetCodigo() + ", descrição: " + canal.GetDescricao());

                if (canal.Equals(Canal.Site_Internet)) 
                {
                    Console.WriteLine(" >>>> Este enum possui tratamento especial");
                }
                else
                {
                    Console.WriteLine("");
                }
            }   
        }
    }
}
