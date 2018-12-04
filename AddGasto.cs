using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class AddGasto : Form
    {
        //SQL SOURCE
        private string data = "Data Source=DESKTOP-7B08VIG\\SQLEXPRESS;Initial Catalog = Connection; Integrated Security = True";
        bool check = true;

        public AddGasto()
        {
            InitializeComponent();
            ingresoLabel.Text = ControlIngresos.AddIngreso.ToString();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Check if text is Double.
                bool textBoxGastoToDouble = double.TryParse(textBoxGasto.Text, out double txtDoubleConverted);

                //"ValidatingConditions" Method shows MessageBox for each invalid conditions, and returns false.
                if (ValidatingConditions(textBoxGastoToDouble, listBox1.SelectedIndex, txtDoubleConverted))
                { 
                    // Adding expense then clears textBox.
                    ControlIngresos.AddGasto = txtDoubleConverted;
                    ingresoLabel.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");
                    gastoLabel.Text = "$" + ControlIngresos.AddGasto.ToString("0.00");
                    textBoxGasto.Clear();

                    //Adds the expense to detailed listViews.
                    ListViewItem detailedItems = new ListViewItem(DateTime.Now.ToString());
                    detailedItems.SubItems.Add(txtDoubleConverted.ToString("0.00"));
                    detailedItems.SubItems.Add(listBox1.SelectedItem.ToString());
                    StaticForms.ListTrackingForm.listViewTracking.Items.Add(detailedItems);

                    //Update items on ''%ofExpensesList'' 
                    StaticForms.ListTrackingForm.listViewWasted.Items.Clear();
                    Porcentajes updatelistView = new Porcentajes();
                    updatelistView.AddItemToDicc(listBox1.SelectedItem.ToString(), txtDoubleConverted);
                    updatelistView.AddItemPercentageTolistViewWasted();


                    //SQL
                    SqlConnection con = new SqlConnection(data);
                    con.Open();

                    string q = "INSERT INTO Gastos(Fecha,Egreso,Tipo)VALUES('" + DateTime.Now.ToString() + "','" + txtDoubleConverted + "','" + listBox1.SelectedItem + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        
        public bool ValidatingConditions(bool validatedDouble,int listIndex, double txtConverted)
        {
            if (!validatedDouble)
            { MessageBox.Show("¡Los valores ingresados no son correctos o están vacíos!");
                return false;
            }
            else if (listIndex == -1)
            { MessageBox.Show("¡Debe seleccionar un item antes de proceder!");
                return false;
            }
            else if (txtConverted < 0)
            { MessageBox.Show("No puede ingresar valores negativos o iguales a 0.");
                return false;
            }
            else if (txtConverted > ControlIngresos.AddIngreso)
            { MessageBox.Show("No puede gastar más de lo que gana: " + ControlIngresos.AddIngreso);
                return false;
            }
            else
            { return true; }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddElementButton(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxAddNewElement.Text))
                {
                    MessageBox.Show("Debe ingresar algo antes de continuar.");
                }
                else
                {
                    listBox1.Items.Add(textBoxAddNewElement.Text.ToString());
                    textBoxAddNewElement.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveElementButton(object sender, EventArgs e)
        { 
            try
            {
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("¡No hay elementos en la lista!");
                }
                else if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un item antes de continuar.");
                }
                else
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModifyElementButton(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("¡No hay elementos en la lista!");
                }
                else if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un item antes de continuar.");
                }
                
                else if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Debe ingresar algo antes de continuar.");
                }
                else
                {
                    listBox1.Items.Insert(listBox1.SelectedIndex, textBox3.Text.ToString());
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    textBox3.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderListButton(object sender, EventArgs e)
        {
            //Ordering list using LINQ
            if(check)
            {
                List<string> AscList = new List<string>(listBox1.Items.Cast<string>());
                AscList = AscList.OrderBy(li => li).ToList<string>();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(AscList.ToArray());
                check = false;
            }
            else
            {
                List<string> DescList = new List<string>(listBox1.Items.Cast<string>());
                DescList = DescList.OrderByDescending(li => li).ToList<string>();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(DescList.ToArray());
                check = true;
            }
            
            
        }
    }
}
