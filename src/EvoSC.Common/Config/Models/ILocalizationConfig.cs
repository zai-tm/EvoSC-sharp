using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Config.Net;

namespace EvoSC.Common.Config.Models;
public interface ILocalizationConfig
{
    [Description("The culture info used for localization")]
    [Option(Alias = "culture", DefaultValue = "en")]
    public CultureInfo CultureInfo { get; }

    [Description("The fallback culture info if your set culture could not be found")]
    [Option(Alias = "fallback", DefaultValue = "en")]
    public CultureInfo FallbackCultureInfo { get; }
}
