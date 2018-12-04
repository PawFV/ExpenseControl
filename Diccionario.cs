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
    public class Porcentajes
    {
       static Dictionary<string, double > PercentageItemsDict = new Dictionary<string, double>();
        
        public void AddItemPercentageTolistViewWasted()
        {
            foreach (KeyValuePair<string, double> element in PercentageItemsDict)
            {
                double Percentage = DoingPercentage(element.Value);
                int PercentageINT = (int)Percentage;
                ListViewItem AddPercentageItem = new ListViewItem(element.Key);
                AddPercentageItem.SubItems.Add(PercentageINT.ToString() + "%");
                StaticForms.ListTrackingForm.listViewWasted.Items.Add(AddPercentageItem);
            }
        }

        private double DoingPercentage(double ItemTotalGastado)
        {
            double PercentageOfItem = ItemTotalGastado * 100 / ControlIngresos.TOTAL;
            return PercentageOfItem;
        }

        public void AddItemToDicc(string a, double b)
        {
            if (PercentageItemsDict.ContainsKey(a))
            {
                PercentageItemsDict.TryGetValue(a, out double Value);
                double sum = Value + b;
                PercentageItemsDict[a] = sum;
            }
            else
            {
                PercentageItemsDict.Add(a, b);
            }
        }
        
    }
}
