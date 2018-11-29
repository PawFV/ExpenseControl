using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    class Porcentajes
    {
       
       static readonly Dictionary<string, float> PercentageItemsDict = new Dictionary<string, float>();
        
        public void AddItemPercentageTolistViewWasted()
        {
            foreach (KeyValuePair<string, float> element in PercentageItemsDict)
            {
                float Percentage = DoingPercentage(element.Value);
                int PercentageINT = (int)Percentage;
                ListViewItem AddPercentageItem = new ListViewItem(element.Key);
                AddPercentageItem.SubItems.Add(PercentageINT.ToString() + "%");
                StaticForms.FormListTracking.listViewWasted.Items.Add(AddPercentageItem);
            }
        }

        private float DoingPercentage(float ItemTotalGastado)
        {
            float PercentageOfItem = ItemTotalGastado * 100 / ControlIngresos.TOTAL;
            return PercentageOfItem;
        }

        public void AddItemToDicc(string a, float b)
        {
            if (PercentageItemsDict.ContainsKey(a))
            {
                PercentageItemsDict.TryGetValue(a, out float Value);
                float sum = Value + b;
                PercentageItemsDict[a] = sum;
            }
            else
            {
                PercentageItemsDict.Add(a, b);
            }
        }
         
    }
}
