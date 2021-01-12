// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    [System.Serializable]
    public class SavePathSettings
    {
        public BasePathsPerPlatform BasePaths { get { return basePaths; } }

        [Tooltip(@"Decides the root folders for where the saves go. 
DataPath is the game's root folder (or the Assets folder if playing in the Editor)
PersistentDataPath varies depending on platform. On Windows Desktop, it's somewhere in AppData.")]
        [SerializeField] protected BasePathsPerPlatform basePaths;
        public class BasePathsPerPlatform
        {
            public BaseSavePath windowsDesktop = BaseSavePath.dataPath;
            public BaseSavePath linuxDesktop = BaseSavePath.dataPath;
            public BaseSavePath appleDesktop = BaseSavePath.dataPath;

            public BaseSavePath androidPhone = BaseSavePath.persistentDataPath;
            public BaseSavePath applePhone = BaseSavePath.persistentDataPath;
            // ^ Why not iOS? Future-proofing in case Apple decides to rebrand it.

            [Tooltip("For platforms besides the above.")]
            public BaseSavePath other = BaseSavePath.dataPath;
        }

        public RelativePathsPerPlatform RelativePaths { get { return relativePaths; } }

        [Tooltip("Relative to the base paths.")]
        [SerializeField] protected RelativePathsPerPlatform relativePaths;

        public class RelativePathsPerPlatform
        {
            public string windowsDesktop = "Save";
            public string linuxDesktop = "Save";
            public string appleDesktop = "Save";

            public string androidPhone = "Save";
            public string applePhone = "Save";

            [Tooltip("For platforms not included in the above.")]
            public string other = "Save";
        }

        public virtual void Init()
        {
            InitBaseSavePathsOnDisk();
        }

        protected virtual void InitBaseSavePathsOnDisk()
        {

        }

    }
}
