namespace WindowsFormsApp9
{
    partial class AddGasto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxGasto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ingresoLabel = new System.Windows.Forms.Label();
            this.gastoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxAddNewElement = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxGasto
            // 
            this.textBoxGasto.Location = new System.Drawing.Point(15, 62);
            this.textBoxGasto.Name = "textBoxGasto";
            this.textBoxGasto.Size = new System.Drawing.Size(120, 20);
            this.textBoxGasto.TabIndex = 23;
            this.textBoxGasto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Income
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "Income";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "DISPONIBLE";
            // 
            // ingresoLabel
            // 
            this.ingresoLabel.AutoSize = true;
            this.ingresoLabel.Location = new System.Drawing.Point(89, 9);
            this.ingresoLabel.Name = "ingresoLabel";
            this.ingresoLabel.Size = new System.Drawing.Size(13, 13);
            this.ingresoLabel.TabIndex = 25;
            this.ingresoLabel.Text = "0";
            // 
            // gastoLabel
            // 
            this.gastoLabel.AutoSize = true;
            this.gastoLabel.Location = new System.Drawing.Point(89, 36);
            this.gastoLabel.Name = "gastoLabel";
            this.gastoLabel.Size = new System.Drawing.Size(13, 13);
            this.gastoLabel.TabIndex = 28;
            this.gastoLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "GASTOS";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Alquiler",
            "Servicios",
            "Alimentos",
            "Restaurantes",
            "Ocio",
            "Muebles/electrodomésticos"});
            this.listBox1.Location = new System.Drawing.Point(141, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 121);
            this.listBox1.TabIndex = 29;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Agregar item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddElementButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Quitar item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RemoveElementButton);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ModifyElementButton);
            // 
            // textBoxAddNewElement
            // 
            this.textBoxAddNewElement.Location = new System.Drawing.Point(288, 6);
            this.textBoxAddNewElement.Name = "textBoxAddNewElement";
            this.textBoxAddNewElement.Size = new System.Drawing.Size(139, 20);
            this.textBoxAddNewElement.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(288, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(249, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 20);
            this.button6.TabIndex = 35;
            this.button6.Text = "A-Z";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OrderListButton);
            // 
            // AddGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 152);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxAddNewElement);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gastoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ingresoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGasto);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxGasto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ingresoLabel;
        public System.Windows.Forms.Label gastoLabel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxAddNewElement;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
    }
}