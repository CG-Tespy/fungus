// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)

using DateTime = System.DateTime;

namespace Fungus
{
    /// <summary>
    /// Save Data specifically for Save Slot Views, which they use to decide how to
    /// do their jobs.
    /// If you want your slots to display something not supported right out of the
    /// box, subclass this and have your custom views rely on it.
    /// </summary>
    public class SaveSlotViewData
    {
        public int saveNumber = 0; // Helps connect this instance to the right view
        public string description = "";
        public DateTime lastWritten;
    }
}