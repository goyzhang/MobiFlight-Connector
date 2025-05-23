﻿using MobiFlight.Modifier;
using MobiFlight.OutputConfig;

namespace MobiFlight
{
    public interface IFsuipcConfigItem
    {
        FsuipcOffset FSUIPC { get; set; }
        string Value { get; set; }

        ModifierList Modifiers { get; set; }
    }
}
