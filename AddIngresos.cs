using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class AddIngresos : Form
    {
        public AddIngresos()
        {
            InitializeComponent();
            label2.Text = ControlIngresos.AddIngreso.ToString();
        }
        // + ingresos
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                bool Txt1ConversionSuccess = float.TryParse(textBox1.Text, out float txtFloat1);
               
                #region ¡CONDICIONES!
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    { MessageBox.Show("No puede dejar éste campo vacío."); }
                }

                else if (!Txt1ConversionSuccess)
                { MessageBox.Show("¡Debe ingresar sólo números"); }
                else if (txtFloat1>99000000)
                { MessageBox.Show("¡Debe ingresar valores que no excedan 99.000.000"); }
                else if (txtFloat1 <= 0)
                { MessageBox.Show("No puede ingresar valores negativos o iguales a 0."); }
                #endregion
                
                else
                {   // Agrega el ingreso, y actualiza el texto.
                    ControlIngresos.TOTAL = txtFloat1;
                    ControlIngresos.AddIngreso = txtFloat1;
                    label2.Text = "$" + ControlIngresos.AddIngreso.ToString("0.00");

                    textBox1.Clear();

                    ListViewItem AgregarItem = new ListViewItem(DateTime.Now.ToString());
                    AgregarItem.SubItems.Add(txtFloat1.ToString("0.00"));
                    AgregarItem.SubItems.Add("Ingreso");
                    StaticForms.FormListTracking.listViewTracking.Items.Add(AgregarItem);

                    StaticForms.FormListTracking.listViewWasted.Items.Clear();
                    Porcentajes updatelistView = new Porcentajes();
                    updatelistView.AddItemPercentageTolistViewWasted();

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
