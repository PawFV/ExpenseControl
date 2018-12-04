namespace WindowsFormsApp9
{
    partial class PanelPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelExpense = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.buttonAddIncome = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelExpense
            // 
            this.labelExpense.AutoSize = true;
            this.labelExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpense.Location = new System.Drawing.Point(12, 101);
            this.labelExpense.Name = "labelExpense";
            this.labelExpense.Size = new System.Drawing.Size(27, 20);
            this.labelExpense.TabIndex = 27;
            this.labelExpense.Text = "$0";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "GASTOS";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncome.Location = new System.Drawing.Point(12, 41);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(27, 20);
            this.labelIncome.TabIndex = 23;
            this.labelIncome.Text = "$0";
            // 
            // buttonAddIncome
            // 
            this.buttonAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddIncome.Location = new System.Drawing.Point(176, 9);
            this.buttonAddIncome.Name = "buttonAddIncome";
            this.buttonAddIncome.Size = new System.Drawing.Size(120, 40);
            this.buttonAddIncome.TabIndex = 22;
            this.buttonAddIncome.Text = "Agregar ingreso";
            this.buttonAddIncome.UseVisualStyleBackColor = true;
            this.buttonAddIncome.Click += new System.EventHandler(this.ButtonAddIncome);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(176, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ver movimientos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonShowTrackingList);
            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddExpense.Location = new System.Drawing.Point(176, 55);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Size = new System.Drawing.Size(120, 40);
            this.buttonAddExpense.TabIndex = 18;
            this.buttonAddExpense.Text = "Agregar gasto";
            this.buttonAddExpense.UseVisualStyleBackColor = true;
            this.buttonAddExpense.Click += new System.EventHandler(this.ButtoAddExpense);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "DISPONIBLE";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(12, 162);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(27, 20);
            this.labelTotal.TabIndex = 29;
            this.labelTotal.Text = "$0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "TOTAL";
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 205);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.buttonAddIncome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddExpense);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de ingresos";
            this.Load += new System.EventHandler(this.PanelPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddIncome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label6;
    }
}

