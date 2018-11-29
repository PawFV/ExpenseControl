using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp9
{
    public static class StaticForms
    {
        // Static Forms.
        public static FormListTrackingMoney FormListTracking { get; } = new FormListTrackingMoney();
        public static AddGasto GastoForm { get; } = new AddGasto();
        public static AddIngresos IngresoForm { get; } = new AddIngresos();
    }
    
    // Static values!
    public static class ControlIngresos
    {
        private  static float _TotIngreso;
        private  static float _TotGasto;
        private  static float _TOTAL;
         
        static public float AddGasto
        {
            get { return _TotGasto; }
            set { _TotIngreso = _TotIngreso - value; _TotGasto = _TotGasto + value; }
        }
        
        static public float AddIngreso
        {
            get { return _TotIngreso; }
            set { _TotIngreso = _TotIngreso + value; }
        }

        static public float TOTAL
        {
            get { return _TOTAL; }
            set { _TOTAL = _TOTAL + value; }
        }
        
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new PanelPrincipal());
        }
    }
}
