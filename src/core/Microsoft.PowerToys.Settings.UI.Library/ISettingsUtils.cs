﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.PowerToys.Settings.UI.Library.Interfaces;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public interface ISettingsUtils
    {
        T GetSettings<T>(string powertoy = "", string fileName = "settings.json")
            where T : ISettingsConfig, new();

        void SaveSettings(string jsonSettings, string powertoy = "", string fileName = "settings.json");

        bool SettingsExists(string powertoy = "", string fileName = "settings.json");

        void DeleteSettings(string powertoy = "");
    }
}