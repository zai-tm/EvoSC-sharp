using System.Globalization;
using System.Reflection;
using System.Resources;
using EvoSC.Common.Config.Models;
using EvoSC.Modules;
using EvoSC.Modules.Attributes;
using EvoSC.Modules.Interfaces;
using EvoSC.Modules.Official.Player.Interfaces;
using Microsoft.Extensions.Logging;

namespace SimpleModule;

[Module]
public class SimpleModule : EvoScModule, IToggleable
{
    private IEvoScBaseConfig _config;
    private ILogger<SimpleModule> _logger;
    private ResourceManager _resManager;
    private CultureInfo _cultureInfo;

    public SimpleModule(IEvoScBaseConfig config, ILogger<SimpleModule> logger, ResourceManager resManager)
    {
        _config = config;
        _logger = logger;
        _resManager = resManager;
    }

    public Task Enable()
    {
        _cultureInfo = _config.Localization.CultureInfo;
        _logger.LogDebug(_resManager.GetString("SimpleModule.helloworld", _cultureInfo));
        return Task.CompletedTask;
    }

    public Task Disable()
    {
        return Task.CompletedTask;
    }
}
