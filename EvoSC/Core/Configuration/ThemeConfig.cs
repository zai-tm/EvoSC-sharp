﻿using System.Reflection;
using Tomlet.Attributes;

namespace EvoSC.Core.Configuration
{
    public class Theme
    {

        [TomlProperty("theme.default")] public string Default { get; set; }

        [TomlProperty("theme.info")] public string Info { get; set; }

        [TomlProperty("theme.highlight")] public string Highlight { get; set; }

        [TomlProperty("theme.success")] public string Success { get; set; }

        [TomlProperty("theme.warning")] public string Warning { get; set; }

        [TomlProperty("theme.danger")] public string Danger { get; set; }
    }
}