using System;
using System.Globalization;
using System.Linq;
using TesteEnum.Exceptions;
using static TesteEnum.Utils.EnumFlags;

namespace TesteEnum.Utils
{
    public static class EnumExtensions
    {
        public static string GetCodigo<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = System.Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var codigoAttribute = memInfo[0]
                            .GetCustomAttributes(typeof(CodigoAttribute), false)
                            .FirstOrDefault() as CodigoAttribute;

                        if (codigoAttribute != null)
                        {
                            return codigoAttribute.Valor;
                        }
                    }
                }
            }

            throw new CodigoNaoDefinidoException("Código não definido para o Enum: " + e);
        }

        public static string GetDescricao<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = System.Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var descricaoAttribute = memInfo[0]
                            .GetCustomAttributes(typeof(DescricaoAttribute), false)
                            .FirstOrDefault() as DescricaoAttribute;

                        if (descricaoAttribute != null)
                        {
                            return descricaoAttribute.Valor;
                        }
                    }
                }
            }

            throw new DescricaoNaoDefinidaException("Descrição não definida para o Enum: " + e);
        }

        public static T FromCodigo<T>(string valor) where T : IConvertible
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(CodigoAttribute)) as CodigoAttribute;
                    
                if (attribute != null)
                {
                    if (attribute.Valor == valor)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == valor)
                        return (T)field.GetValue(null);
                }
            }
            
            throw new CodigoNaoEncontradoException("Código não encontrado: " + valor);
        }
    }

}