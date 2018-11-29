using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp9
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        // ++ Income
        private void ButtonAddIncome(object sender, EventArgs e)
        {
             StaticForms.IngresoForm.label2.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");
            StaticForms.IngresoForm.ShowDialog();
            labelIncome.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");
            labelTotal.Text = "$" + ControlIngresos.TOTAL.ToString("0.00");       
        }
        
        // ++ Expense
        private void ButtoAddExpense(object sender, EventArgs e)
        {
            StaticForms.GastoForm.ingresoLabel.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");
            StaticForms.GastoForm.gastoLabel.Text = "$" + ControlIngresos.AddGasto.ToString("0.00");
            StaticForms.GastoForm.ShowDialog();
            labelIncome.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");
            labelExpense.Text = "$" + ControlIngresos.AddGasto.ToString("0.00");
        }
        // Shows List of movements (sort of database for user)
        private void ButtonShowTrackingList(object sender, EventArgs e)
        {
            if (StaticForms.FormListTracking.listViewTracking.Items.Count != 0)
            {
                StaticForms.FormListTracking.Income.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");
                StaticForms.FormListTracking.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay movimientos.");
            }
        }
        

    }
}
