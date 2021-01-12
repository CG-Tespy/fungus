// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)
using UnityEngine;


namespace Fungus
{
    /// <summary>
    /// Provides a way to let the user decide where the save files get written to
    /// on disk, based on the platform the game's running on.
    /// </summary>
    public class SaveFilePlacement : MonoBehaviour
    {
        [SerializeField] protected SavePathSettings pathSettings;

    }

    /// <summary>
    /// Enum for the platforms Unity can export to that are supported by Fungus.
    /// </summary>
    public enum Platform
    {
        windowsDesktop,
        linuxDesktop,
        macDesktop,
        androidPhone,
        applePhone,
        other
    }

    /// <summary>
    /// Enum for the base save paths where save files get written to disk.
    /// </summary>
    public enum BaseSavePath
    {
        dataPath,
        persistentDataPath
    }


}