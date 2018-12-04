using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp9
{
    public partial class AddIngresos : Form
    {
        private string data = "Data Source=DESKTOP-7B08VIG\\SQLEXPRESS;Initial Catalog = Connection; Integrated Security = True";

        public AddIngresos()
        {
            InitializeComponent();
            
        }
        // + ingresos
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                bool Txt1ConversionSuccess = double.TryParse(textBox1.Text, out double txtDouble1);
               
                #region ¡CONDICIONES!
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    { MessageBox.Show("No puede dejar éste campo vacío."); }
                }

                else if (!Txt1ConversionSuccess)
                { MessageBox.Show("¡Debe ingresar sólo números"); }
                else if (txtDouble1>99000000)
                { MessageBox.Show("¡Debe ingresar valores que no excedan 99.000.000"); }
                else if (txtDouble1 <= 0)
                { MessageBox.Show("No puede ingresar valores negativos o iguales a 0."); }
                #endregion
                
                else
                {   // Agrega el ingreso, y actualiza el texto.
                    ControlIngresos.TOTAL = txtDouble1;
                    ControlIngresos.AddIngreso = txtDouble1;
                    label2.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");

                    textBox1.Clear();

                    ListViewItem AgregarItem = new ListViewItem(DateTime.Now.ToString());
                    AgregarItem.SubItems.Add(txtDouble1.ToString("0.00"));
                    AgregarItem.SubItems.Add("Ingreso");
                    StaticForms.ListTrackingForm.listViewTracking.Items.Add(AgregarItem);

                    StaticForms.ListTrackingForm.listViewWasted.Items.Clear();
                    Porcentajes updatelistView = new Porcentajes();
                    updatelistView.AddItemPercentageTolistViewWasted();


                    //SQL
                    SqlConnection con = new SqlConnection(data);
                    con.Open();

                    string q = "INSERT INTO Gastos(Fecha,Ingreso,Tipo)VALUES('" + DateTime.Now.ToString() + "','" + txtDouble1 + "','Ingreso')";
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
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
