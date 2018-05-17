﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using System.IO;
using CommandLineResources = Microsoft.VisualStudio.TestPlatform.CommandLine.Resources.Resources;

namespace Microsoft.VisualStudio.TestPlatform.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine(string.Format(CultureInfo.CurrentCulture, CommandLineResources.ValidUsage));
                return;
            }

            string oldFilePath = args[0];
            string newFilePath = args[1];

            if (!Path.IsPathRooted(oldFilePath) || !Path.IsPathRooted(newFilePath) || !string.Equals(Path.GetExtension(newFilePath), RunSettingsExtension))
            {
                Console.WriteLine(string.Format(CultureInfo.CurrentCulture, CommandLineResources.ValidUsage));
                return;
            }

            var migrator = new Migrator();

            if (string.Equals(Path.GetExtension(oldFilePath), TestSettingsExtension))
            {
                migrator.MigrateTestSettings(oldFilePath, newFilePath);
            }
            else if (string.Equals(Path.GetExtension(oldFilePath), RunSettingsExtension))
            {
                migrator.MigrateRunSettings(oldFilePath, newFilePath);
            }
            else
            {
                Console.WriteLine(string.Format(CultureInfo.CurrentCulture, CommandLineResources.ValidUsage));
                return;
            }
        }

        const string RunSettingsExtension = ".runsettings";
        const string TestSettingsExtension = ".testsettings";
    }
}

