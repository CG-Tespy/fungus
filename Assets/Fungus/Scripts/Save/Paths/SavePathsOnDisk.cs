// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Fungus
{
    /// <summary>
    /// Maintains the actual paths on the user's computer based on the user settings.
    /// Requires a SaveFilePlacement in the scene to be set up properly.
    /// </summary>
    public static class SavePathsOnDisk
    {
        public static void SetFrom(SavePathSettings settings)
        {
            RefreshBaseSavePaths();
            // ^ Initializing these in a static constructor may not work, so...
            GetPathsFrom(settings);
            SetForDesktop();
            SetForMobile();
        }

        static void RefreshBaseSavePaths()
        {
            baseSavePathsOnDisk[BaseSavePath.dataPath] = Application.dataPath;
            baseSavePathsOnDisk[BaseSavePath.persistentDataPath] = Application.persistentDataPath;
        }

        static Dictionary<BaseSavePath, string> baseSavePathsOnDisk = new Dictionary<BaseSavePath, string>();

        static void GetPathsFrom(SavePathSettings settings)
        {
            basePaths = settings.BasePaths;
            relativePaths = settings.RelativePaths;
        }

        static SavePathSettings.BasePathsPerPlatform basePaths;
        static SavePathSettings.RelativePathsPerPlatform relativePaths;

        #region Desktop Path Setup

        static void SetForDesktop()
        {
            var baseOnDisk = baseSavePathsOnDisk[basePaths.windowsDesktop];
            var relativeForPlatform = relativePaths.windowsDesktop;
            WindowsDesktop = Path.Combine(baseOnDisk, relativeForPlatform);

            baseOnDisk = baseSavePathsOnDisk[basePaths.linuxDesktop];
            relativeForPlatform = relativePaths.linuxDesktop;
            LinuxDesktop = Path.Combine(baseOnDisk, relativeForPlatform);

            baseOnDisk = baseSavePathsOnDisk[basePaths.appleDesktop];
            relativeForPlatform = relativePaths.appleDesktop;
            AppleDesktop = Path.Combine(baseOnDisk, relativeForPlatform);

        }

        public static string WindowsDesktop { get; private set; }
        public static string LinuxDesktop { get; private set; }
        public static string AppleDesktop { get; private set; }
        #endregion

        #region Mobile Path Setup

        static void SetForMobile()
        {
            var baseOnDisk = baseSavePathsOnDisk[basePaths.androidPhone];
            var relativeForPlatform = relativePaths.androidPhone;
            AndroidPhone = Path.Combine(baseOnDisk, relativeForPlatform);

            baseOnDisk = baseSavePathsOnDisk[basePaths.applePhone];
            relativeForPlatform = relativePaths.applePhone;
            ApplePhone = Path.Combine(baseOnDisk, relativeForPlatform);
        }

        public static string AndroidPhone { get; private set; }
        public static string ApplePhone { get; private set; }
        #endregion

        #region Other Path Setup
        static void SetOther()
        {
            var baseOnDisk = baseSavePathsOnDisk[basePaths.other];
            var relativeForPlatform = relativePaths.other;
            Other = Path.Combine(baseOnDisk, relativeForPlatform);
        }

        public static string Other { get; private set; }
        #endregion
    }
}