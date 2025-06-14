﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App.Core
{
    internal class RegistryCleaner
    {
        public static void CleanRegistry()
        {
           
            string[] registryKeys = new string[]
            {
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{436D67E1-2FB3-4A6C-B3CD-FF8A41B0664D}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{5312C54E-A385-46B7-B200-ABAF81B03935}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{6DDF00DB-1234-46EC-8356-27E7B2051192}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{9C9D53D4-A978-43FC-93E2-1C21B529E6D7}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{D5B91409-A8CA-4973-9A0B-59F713D25671}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{E6871B76-C3C8-44DD-B947-ABFFE144860D}",
            @"HKEY_CURRENT_USER\Software\Classes\CLSID\{E8CF4E59-B7A3-41F2-86C7-82B03334F22A}",

            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{436D67E1-2FB3-4A6C-B3CD-FF8A41B0664D}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{5312C54E-A385-46B7-B200-ABAF81B03935}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{6DDF00DB-1234-46EC-8356-27E7B2051192}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{9C9D53D4-A978-43FC-93E2-1C21B529E6D7}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{D5B91409-A8CA-4973-9A0B-59F713D25671}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{E6871B76-C3C8-44DD-B947-ABFFE144860D}",
            @"HKEY_CURRENT_USER\Software\Classes\Wow6432Node\CLSID\{E8CF4E59-B7A3-41F2-86C7-82B03334F22A}",

            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{436D67E1-2FB3-4A6C-B3CD-FF8A41B0664D}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{5312C54E-A385-46B7-B200-ABAF81B03935}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{6DDF00DB-1234-46EC-8356-27E7B2051192}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{9C9D53D4-A978-43FC-93E2-1C21B529E6D7}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{D5B91409-A8CA-4973-9A0B-59F713D25671}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{E6871B76-C3C8-44DD-B947-ABFFE144860D}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\CLSID\{E8CF4E59-B7A3-41F2-86C7-82B03334F22A}",

            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{436D67E1-2FB3-4A6C-B3CD-FF8A41B0664D}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{5312C54E-A385-46B7-B200-ABAF81B03935}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{6DDF00DB-1234-46EC-8356-27E7B2051192}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{9C9D53D4-A978-43FC-93E2-1C21B529E6D7}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{D5B91409-A8CA-4973-9A0B-59F713D25671}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{E6871B76-C3C8-44DD-B947-ABFFE144860D}",
            @"HKEY_LOCAL_MACHINE\Software\Classes\Wow6432Node\CLSID\{E8CF4E59-B7A3-41F2-86C7-82B03334F22A}",

            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{436D67E1-2FB3-4A6C-B3CD-FF8A41B0664D}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{5312C54E-A385-46B7-B200-ABAF81B03935}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{6DDF00DB-1234-46EC-8356-27E7B2051192}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{9C9D53D4-A978-43FC-93E2-1C21B529E6D7}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{D5B91409-A8CA-4973-9A0B-59F713D25671}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{E6871B76-C3C8-44DD-B947-ABFFE144860D}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\CLSID\{E8CF4E59-B7A3-41F2-86C7-82B03334F22A}",

            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{436D67E1-2FB3-4A6C-B3CD-FF8A41B0664D}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{5312C54E-A385-46B7-B200-ABAF81B03935}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{6DDF00DB-1234-46EC-8356-27E7B2051192}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{9C9D53D4-A978-43FC-93E2-1C21B529E6D7}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{D5B91409-A8CA-4973-9A0B-59F713D25671}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{E6871B76-C3C8-44DD-B947-ABFFE144860D}",
            @"HKEY_USERS\.DEFAULT\Software\Classes\Wow6432Node\CLSID\{E8CF4E59-B7A3-41F2-86C7-82B03334F22A}",

            @"HKEY_LOCAL_MACHINE\Software\Wow6432Node\Internet Download Manager",
            @"HKEY_LOCAL_MACHINE\Software\Internet Download Manager",
            @"HKEY_CURRENT_USER\Software\Wow6432Node\DownloadManager"
            };

            foreach (string keyPath in registryKeys)
            {
                try
                {
                    string hive = keyPath.Split('\\')[0];
                    string subKey = keyPath.Substring(hive.Length + 1);
                    RegistryKey baseKey = hive switch
                    {
                        "HKEY_LOCAL_MACHINE" => Registry.LocalMachine,
                        "HKEY_CURRENT_USER" => Registry.CurrentUser,
                        "HKEY_USERS" => Registry.Users,
                        _ => null
                    };

                    if (baseKey != null)
                    {
                        baseKey.DeleteSubKeyTree(subKey, false);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting {keyPath}: {ex.Message}");
                }
            }

          
            try
            {
                using (RegistryKey dmKey = Registry.CurrentUser.OpenSubKey(@"Software\DownloadManager", writable: true))
                {
                    if (dmKey != null)
                    {
                        string[] valueNames = new string[]
                        {
                        "Email", "Serial", "scansk", "Model", "MData", "Therad", "tvfrdt",
                        "LstCheck", "CheckUpdtVM", "radxcnt", "ptrk_scdt", "LastCheckQU"
                        };

                        foreach (string value in valueNames)
                        {
                            dmKey.DeleteValue(value, false);
                        }

                        dmKey.SetValue("LaunchOnStart", 1, RegistryValueKind.DWord);
                        dmKey.SetValue("nLst", 1, RegistryValueKind.DWord);
                        dmKey.SetValue("LName", " ", RegistryValueKind.String);
                        dmKey.SetValue("FName", "User", RegistryValueKind.String);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error modifying values: {ex.Message}");
            }

            Console.WriteLine("Registry cleanup completed successfully.");
        }
    }
}
