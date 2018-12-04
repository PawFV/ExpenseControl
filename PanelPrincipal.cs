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
        private string data = "Data Source=DESKTOP-7B08VIG\\SQLEXPRESS;Initial Catalog = Connection; Integrated Security = True";

        public PanelPrincipal()
        {
            InitializeComponent();
           
        }
        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            
            string loadDisponible = "select (SUM(Ingreso)-SUM(Egreso)) from Gastos";
            string loadGasto = "select SUM (Egreso) Egreso from Gastos";
            string loadTotal = "select SUM(Ingreso) tot from Gastos";
            string loadListaDeMovimientos = "select Fecha,Ingreso+Egreso as Detalle,Tipo from Gastos";
            string loadListaPorcentaje = "select Tipo,SUM(Egreso) as 'Egresos' from Gastos where Egreso<>0 Group By Tipo";

            using (SqlConnection con = new SqlConnection(data))
            {
                con.Open();
                
                using (SqlCommand cmd2 = new SqlCommand(loadGasto, con))
                {
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    rd2.Read();
                    if (rd2.HasRows && !rd2.IsDBNull(0))
                    {
                        ControlIngresos.AddGasto = rd2.GetDouble(0);
                        labelExpense.Text = "$" + ControlIngresos.AddGasto.ToString("0.00");
                    }
                    rd2.Close();
                }

                using (SqlCommand cmd3 = new SqlCommand(loadTotal, con))
                {
                    SqlDataReader rd3 = cmd3.ExecuteReader();
                    rd3.Read();
                    if (rd3.HasRows && !rd3.IsDBNull(0))
                    {
                        ControlIngresos.TOTAL = rd3.GetDouble(0);
                        labelTotal.Text = "$" + ControlIngresos.TOTAL.ToString("0.00");
                    }
                    rd3.Close();
                }
                
                using (SqlCommand cmd1 = new SqlCommand(loadDisponible, con))
                {
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    rd1.Read();
                    if (rd1.HasRows && !rd1.IsDBNull(0))
                    {
                        ControlIngresos.AddIngreso = rd1.GetDouble(0) + ControlIngresos.AddGasto;
                        labelIncome.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");
                    }

                    rd1.Close();
                }

                using (SqlDataAdapter adp = new SqlDataAdapter(loadListaDeMovimientos, con))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    foreach(DataRow d in dt.Rows)
                    {
                        ListViewItem movimientos = new ListViewItem(d[0].ToString());
                        movimientos.SubItems.Add(d[1].ToString());
                        movimientos.SubItems.Add(d[2].ToString());

                        StaticForms.ListTrackingForm.listViewTracking.Items.Add(movimientos);
                    }
                    dt.Dispose();
                }

                using (SqlDataAdapter adp = new SqlDataAdapter(loadListaPorcentaje, con))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    Porcentajes porcentajes = new Porcentajes();
                    foreach (DataRow d in dt.Rows)
                    {
                        porcentajes.AddItemToDicc(d["tipo"].ToString(), (double)d["Egresos"]);
                        
                    }
                    StaticForms.ListTrackingForm.listViewWasted.Items.Clear();
                    
                    porcentajes.AddItemPercentageTolistViewWasted();
                    dt.Dispose();
                }

               
                con.Close();
            }
            
        }
        private void loadDatabase()
        {

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
            if (StaticForms.ListTrackingForm.listViewTracking.Items.Count != 0)
            {
                StaticForms.ListTrackingForm.Income.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");
                StaticForms.ListTrackingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay movimientos.");
            }
        }

        
    }
}
