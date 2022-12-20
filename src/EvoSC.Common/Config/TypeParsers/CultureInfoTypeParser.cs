using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Config.Net;

namespace EvoSC.Common.Config.TypeParsers;
internal class CultureInfoTypeParser : ITypeParser
{
    public bool TryParse(string? value, Type t, out object? result)
    {
        if(value == null || value.Length == 0)
        {
            result = null;
            return false;
        }

        try
        {
            result = CultureInfo.GetCultureInfo(value);
            return true;
        }
        catch(Exception ex)
        {
            result = null;
            return false;
        }
    }

    public string? ToRawString(object? value)
    {
        return value?.ToString();
    }

    public IEnumerable<Type> SupportedTypes => new[] { typeof(CultureInfo) };
}
