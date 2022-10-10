﻿using EvoSC.Modules.Attributes;
using EvoSC.Modules.Builtin.Player;

namespace EvoSC.Modules.Builtin.Info;

[InternalModule(Name, "Provides help and information about the controller.")]
public class InfoModule : IEvoScModule
{
    public const string Name = "Info";
}
