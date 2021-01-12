// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)

using UnityEngine;

namespace Fungus
{
    public interface ISaveSlotView
    {
        /// <summary>
        /// Contains the info the view bases its actions off of.
        /// </summary>
        SaveSlotViewData SaveData { get; set; }

        void Refresh();
    }

    /// <summary>
    /// For components meant to display something based on save data.
    /// </summary>
    public abstract class SaveSlotView : MonoBehaviour, ISaveSlotView
    {
        public SaveSlotViewData SaveData
        {
            get { return saveData; }
            set
            {
                saveData = value;
                Refresh();
            }
        }


        private SaveSlotViewData saveData;

        public abstract void Refresh();

        protected virtual bool HasSaveData
        {
            get { return saveData != null; }
        }

    }
}
